using Sandbox.ModAPI;
using VRage.Game.Components;
using VRage.Game;
using VRage.Game.ModAPI;
using VRageMath;
using System.Collections.Generic;
using VRage.Utils;
using Sandbox.Definitions;
using VRage.Library.Utils;
using System.Diagnostics;

namespace JasperGaming.TritaniumConversion
{
    [MySessionComponentDescriptor(MyUpdateOrder.AfterSimulation)]
    public class TritaniumConversion : MySessionComponentBase
    {
        public static TritaniumConversion Instance;

        private BlockDictionary blockDict;
        private bool convertActive = false;
        List<IMySlimBlock> reuse_slim = new List<IMySlimBlock>();
        MyDefinitionId reuse_id;
        MyDefinitionBase reuse_base;
        private bool debug = false;

        public override void Init(MyObjectBuilder_SessionComponent sessionComponent)
        {
            //base.Init(sessionComponent);

            if (!(MyAPIGateway.Session.IsServer && MyAPIGateway.Session.CreativeMode))
            {
                return;
            }

            MyAPIGateway.Utilities.MessageEntered += Utilities_MessageEntered;
        }

        private void Utilities_MessageEntered(string messageText, ref bool sendToOthers)
        {
            if (messageText == "/tritanium")
            {
                if (!(MyAPIGateway.Session.IsServer && MyAPIGateway.Session.CreativeMode))
                {
                    MyAPIGateway.Utilities.ShowMessage("", "Tritanium conversion only works on single-player creative worlds.");
                }
                else
                {
                    convertActive = true;
                    //MyAPIGateway.Utilities.ShowMessage("", "Tritanium conversion active");
                }
                sendToOthers = false;
            }
            else
            {
                sendToOthers = true;
            }
        }

        public override void LoadData()
        {

        }

        public override void BeforeStart()
        {
            // executed before the world starts updating

            // instantiate block dictionary
            blockDict = new BlockDictionary();
        }

        protected override void UnloadData()
        {
            MyAPIGateway.Utilities.MessageEntered -= Utilities_MessageEntered;
            blockDict = null;
            Instance = null; // important for avoiding this object to remain allocated in memory
        }

        public override void Draw()
        {
            // gets called 60 times a second after all other update methods, regardless of framerate, game pause or MyUpdateOrder.
            // NOTE: this is the only place where the camera matrix (MyAPIGateway.Session.Camera.WorldMatrix) is accurate, everywhere else it's 1 frame behind.

            Stopwatch stopwatch = new Stopwatch();

            if (!convertActive) return;
            convertActive = false;

            if ((bool)(!MyAPIGateway.Session.Player?.Character?.IsInFirstPersonView)) return;

            try
            {
                var camera = MyAPIGateway.Session.Camera;
                if (camera != null)
                {
                    IHitInfo hit = null;
                    MyAPIGateway.Physics.CastRay(camera.WorldMatrix.Translation, camera.WorldMatrix.Translation + camera.WorldMatrix.Forward * 100, out hit); // 100 is how far to cast
                    if (hit != null && hit.HitEntity != null && hit.HitEntity is IMyCubeGrid)
                    {
                        IMyCubeGrid grid = hit.HitEntity as IMyCubeGrid;
                        if (!grid.MarkedForClose && grid.Physics != null)
                        {
                            BoundingSphereD sphere = grid.WorldVolume;
                            reuse_slim.Clear();
                            reuse_slim = grid.GetBlocksInsideSphere(ref sphere);

                            //MyAPIGateway.Utilities.ShowMessage("", "grid found, count = " + reuse_slim.Count);

                            stopwatch.Start();

                            foreach (var block in reuse_slim)
                            {
                                string def = block.BlockDefinition.Id.SubtypeName;

                                string newId = blockDict.Convert(def);
                                //MyAPIGateway.Utilities.ShowMessage("", "old id = " + def + ", newId = " + newId);

                                if (newId != null)
                                {
                                    if (debug)
                                    {
                                        MyAPIGateway.Utilities.ShowMessage("", def + " -> " + newId);
                                    }

                                    bool valid = false;
                                    MyObjectBuilder_CubeBlock origBlock = block.GetObjectBuilder(true);
                                    MyObjectBuilder_CubeBlock newBlock = block.GetObjectBuilder(true);

                                    newBlock.SubtypeName = newId;
                                    reuse_id = MyDefinitionId.FromContent(newBlock);
                                    reuse_base = MyDefinitionManager.Static.GetDefinition(reuse_id);
                                    if (reuse_id != null && reuse_base != null && !string.IsNullOrWhiteSpace(reuse_base.Id.SubtypeName))
                                    {
                                        origBlock = newBlock;
                                        origBlock.EntityId = 0;
                                        valid = true;
                                    }

                                    if (valid)
                                    {
                                        grid.RemoveBlock(block, false);
                                        grid.AddBlock(origBlock, false);
                                    }
                                }
                                else
                                {
                                    if (debug)
                                    {
                                        MyAPIGateway.Utilities.ShowMessage("", "block not converted = " + def);
                                    }
                                }

                            }

                            stopwatch.Stop();
                        }
                    }
                }
            }
            catch(System.Exception e)
            {
                MyLog.Default.WriteLine("Jasper Tritanium Conversion: " + e);
            }

            MyAPIGateway.Utilities.ShowMessage("", "Conversion complete: " + reuse_slim.Count + " blocks, " + stopwatch.ElapsedMilliseconds + "ms");
        }

    }
}
