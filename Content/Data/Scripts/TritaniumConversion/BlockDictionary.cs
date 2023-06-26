using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasperGaming.TritaniumConversion
{
    class BlockDictionary
    {
        private Dictionary<string, string> BlockMap = new Dictionary<string, string>()
        {
            //
            // Large grid light armor
            //

            // Panels
            {"LargeArmorPanelLight", "LargeArmorPanelTritanium" },
            {"LargeArmorSlopedPanelLight", "LargeArmorSlopedPanelTritanium" },
            {"LargeArmorSlopedSidePanelLight", "LargeArmorSlopedSidePanelTritanium" },
            {"LargeArmor2x1SlopedPanelLight", "LargeArmor2x1SlopedPanelTritanium" },
            {"LargeArmor2x1SlopedPanelTipLight", "LargeArmor2x1SlopedPanelTipTritanium" },
            {"LargeArmor2x1SlopedSideBasePanelLight", "LargeArmor2x1SlopedSideBasePanelTritanium" },
            {"LargeArmor2x1SlopedSideTipPanelLight", "LargeArmor2x1SlopedSideTipPanelTritanium" },
            {"LargeArmor2x1SlopedSideBasePanelLightInv", "LargeArmor2x1SlopedSideBasePanelTritaniumInv" },
            {"LargeArmor2x1SlopedSideTipPanelLightInv", "LargeArmor2x1SlopedSideTipPanelTritaniumInv" },
            {"LargeArmorHalfSlopedPanelLight", "LargeArmorHalfSlopedPanelTritanium" },
            {"LargeArmor2x1HalfSlopedPanelLightRight", "LargeArmor2x1HalfSlopedPanelTritaniumRight" },
            {"LargeArmor2x1HalfSlopedTipPanelLightRight", "LargeArmor2x1HalfSlopedTipPanelTritaniumRight" },
            {"LargeArmor2x1HalfSlopedPanelLightLeft", "LargeArmor2x1HalfSlopedPanelTritaniumLeft" },
            {"LargeArmor2x1HalfSlopedTipPanelLightLeft", "LargeArmor2x1HalfSlopedTipPanelTritaniumLeft" },
            {"LargeArmorHalfCenterPanelLight", "LargeArmorHalfCenterPanelTritanium" },
            {"LargeArmorHalfPanelLight", "LargeArmorHalfPanelTritanium" },
            {"LargeArmorQuarterPanelLight", "LargeArmorQuarterPanelTritanium" },
            {"LargeArmorCenterPanelLight", "LargeArmorCenterPanelTritanium" },

            // Transitions
            {"LargeBlockArmorSlopeTransitionBase", "Tritanium_LargeBlockArmorSlopeTransitionBase" },
            {"LargeBlockArmorSlopeTransition", "Tritanium_LargeBlockArmorSlopeTransition" },
            {"LargeBlockArmorSlopeTransitionTip", "Tritanium_LargeBlockArmorSlopeTransitionTip" },
            {"LargeBlockArmorSlopeTransitionBaseMirrored", "Tritanium_LargeBlockArmorSlopeTransitionBaseMirrored" },
            {"LargeBlockArmorSlopeTransitionMirrored", "Tritanium_LargeBlockArmorSlopeTransitionMirrored" },
            {"LargeBlockArmorSlopeTransitionTipMirrored", "Tritanium_LargeBlockArmorSlopeTransitionTipMirrored" },

            // Cubes
            {"LargeBlockArmorBlock", "Tritanium_LargeBlockArmorBlock" },
            {"LargeBlockArmorSlope", "Tritanium_LargeBlockArmorSlope" },
            {"LargeBlockArmorCorner", "Tritanium_LargeBlockArmorCorner" },
            {"LargeBlockArmorCornerInv", "Tritanium_LargeBlockArmorCornerInv" },
            {"LargeBlockArmorCornerSquare", "Tritanium_LargeBlockArmorCornerSquare" },
            {"LargeBlockArmorCornerSquareInverted", "Tritanium_LargeBlockArmorCornerSquareInverted" },

            // 2x1
            {"LargeBlockArmorSlope2Base", "Tritanium_LargeBlockArmorSlope2Base" },
            {"LargeBlockArmorSlope2Tip", "Tritanium_LargeBlockArmorSlope2Tip" },
            {"LargeHalfArmorBlock", "Tritanium_LargeHalfArmorBlock" },
            {"LargeHalfSlopeArmorBlock", "Tritanium_LargeHalfSlopeArmorBlock" },
            {"LargeBlockArmorHalfSlopeCorner", "Tritanium_LargeBlockArmorHalfSlopeCorner" },
            {"LargeBlockArmorHalfCorner", "Tritanium_LargeBlockArmorHalfCorner" },
            {"LargeBlockArmorHalfSlopedCorner", "Tritanium_LargeBlockArmorHalfSlopedCorner" },

            // 2x1 Corner
            {"LargeBlockArmorCorner2Base", "Tritanium_LargeBlockArmorCorner2Base" },
            {"LargeBlockArmorCorner2Tip", "Tritanium_LargeBlockArmorCorner2Tip" },
            {"LargeBlockArmorInvCorner2Base", "Tritanium_LargeBlockArmorInvCorner2Base" },
            {"LargeBlockArmorInvCorner2Tip", "Tritanium_LargeBlockArmorInvCorner2Tip" },
            {"LargeBlockArmorHalfSlopeCornerInverted", "Tritanium_LargeBlockArmorHalfSlopeCornerInverted" },
            {"LargeBlockArmorHalfSlopeInverted", "Tritanium_LargeBlockArmorHalfSlopeInverted" },

            // 2x1 Corner Slope
            {"LargeBlockArmorSlopedCornerTip", "Tritanium_LargeBlockArmorSlopedCornerTip" },
            {"LargeBlockArmorRaisedSlopedCorner", "Tritanium_LargeBlockArmorRaisedSlopedCorner" },
            {"LargeBlockArmorSquareSlopedCornerTip", "Tritanium_LargeBlockArmorSquareSlopedCornerTip" },
            {"LargeBlockArmorSquareSlopedCornerBase", "Tritanium_LargeBlockArmorSquareSlopedCornerBase" },
            {"LargeBlockArmorSquareSlopedCornerTipInv", "Tritanium_LargeBlockArmorSquareSlopedCornerTipInv" },
            {"LargeBlockArmorSlopedCornerBase", "Tritanium_LargeBlockArmorSlopedCornerBase" },
            {"LargeBlockArmorSlopedCorner", "Tritanium_LargeBlockArmorSlopedCorner" },
            {"LargeBlockArmorHalfSlopedCornerBase", "Tritanium_LargeBlockArmorHalfSlopedCornerBase" },

            // Round
            {"LargeBlockArmorRoundSlope", "Tritanium_LargeBlockArmorRoundSlope" },
            {"LargeBlockArmorRoundCorner", "Tritanium_LargeBlockArmorRoundCorner" },
            {"LargeBlockArmorRoundCornerInv", "Tritanium_LargeBlockArmorRoundCornerInv" },

            //
            // Small grid light armor
            //

            // Panels
            {"SmallArmorPanelLight", "SmallArmorPanelTritanium" },
            {"SmallArmorSlopedPanelLight", "SmallArmorSlopedPanelTritanium" },
            {"SmallArmorSlopedSidePanelLight", "SmallArmorSlopedSidePanelTritanium" },
            {"SmallArmor2x1SlopedPanelLight", "SmallArmor2x1SlopedPanelTritanium" },
            {"SmallArmor2x1SlopedPanelTipLight", "SmallArmor2x1SlopedPanelTipTritanium" },
            {"SmallArmor2x1SlopedSideBasePanelLight", "SmallArmor2x1SlopedSideBasePanelTritanium" },
            {"SmallArmor2x1SlopedSideTipPanelLight", "SmallArmor2x1SlopedSideTipPanelTritanium" },
            {"SmallArmor2x1SlopedSideBasePanelLightInv", "SmallArmor2x1SlopedSideBasePanelTritaniumInv" },
            {"SmallArmor2x1SlopedSideTipPanelLightInv", "SmallArmor2x1SlopedSideTipPanelTritaniumInv" },
            {"SmallArmorHalfSlopedPanelLight", "SmallArmorHalfSlopedPanelTritanium" },
            {"SmallArmor2x1HalfSlopedPanelLightRight", "SmallArmor2x1HalfSlopedPanelTritaniumRight" },
            {"SmallArmor2x1HalfSlopedTipPanelLightRight", "SmallArmor2x1HalfSlopedTipPanelTritaniumRight" },
            {"SmallArmor2x1HalfSlopedPanelLightLeft", "SmallArmor2x1HalfSlopedPanelTritaniumLeft" },
            {"SmallArmor2x1HalfSlopedTipPanelLightLeft", "SmallArmor2x1HalfSlopedTipPanelTritaniumLeft" },
            {"SmallArmorHalfCenterPanelLight", "SmallArmorHalfCenterPanelTritanium" },
            {"SmallArmorHalfPanelLight", "SmallArmorHalfPanelTritanium" },
            {"SmallArmorQuarterPanelLight", "SmallArmorQuarterPanelTritanium" },
            {"SmallArmorCenterPanelLight", "SmallArmorCenterPanelTritanium" },

            // Transitions
            {"SmallBlockArmorSlopeTransitionBase", "Tritanium_SmallBlockArmorSlopeTransitionBase" },
            {"SmallBlockArmorSlopeTransition", "Tritanium_SmallBlockArmorSlopeTransition" },
            {"SmallBlockArmorSlopeTransitionTip", "Tritanium_SmallBlockArmorSlopeTransitionTip" },
            {"SmallBlockArmorSlopeTransitionBaseMirrored", "Tritanium_SmallBlockArmorSlopeTransitionBaseMirrored" },
            {"SmallBlockArmorSlopeTransitionMirrored", "Tritanium_SmallBlockArmorSlopeTransitionMirrored" },
            {"SmallBlockArmorSlopeTransitionTipMirrored", "Tritanium_SmallBlockArmorSlopeTransitionTipMirrored" },

            // Cubes
            {"SmallBlockArmorBlock", "Tritanium_SmallBlockArmorBlock" },
            {"SmallBlockArmorSlope", "Tritanium_SmallBlockArmorSlope" },
            {"SmallBlockArmorCorner", "Tritanium_SmallBlockArmorCorner" },
            {"SmallBlockArmorCornerInv", "Tritanium_SmallBlockArmorCornerInv" },
            {"SmallBlockArmorCornerSquare", "Tritanium_SmallBlockArmorCornerSquare" },
            {"SmallBlockArmorCornerSquareInverted", "Tritanium_SmallBlockArmorCornerSquareInverted" },

            // 2x1
            {"SmallBlockArmorSlope2Base", "Tritanium_SmallBlockArmorSlope2Base" },
            {"SmallBlockArmorSlope2Tip", "Tritanium_SmallBlockArmorSlope2Tip" },
            {"HalfArmorBlock", "Tritanium_HalfArmorBlock" },
            {"HalfSlopeArmorBlock", "Tritanium_HalfSlopeArmorBlock" },
            {"SmallBlockArmorHalfSlopeCorner", "Tritanium_SmallBlockArmorHalfSlopeCorner" },
            {"SmallBlockArmorHalfCorner", "Tritanium_SmallBlockArmorHalfCorner" },
            {"SmallBlockArmorHalfSlopedCorner", "Tritanium_SmallBlockArmorHalfSlopedCorner" },

            // 2x1 Corner
            {"SmallBlockArmorCorner2Base", "Tritanium_SmallBlockArmorCorner2Base" },
            {"SmallBlockArmorCorner2Tip", "Tritanium_SmallBlockArmorCorner2Tip" },
            {"SmallBlockArmorInvCorner2Base", "Tritanium_SmallBlockArmorInvCorner2Base" },
            {"SmallBlockArmorInvCorner2Tip", "Tritanium_SmallBlockArmorInvCorner2Tip" },
            {"SmallBlockArmorHalfSlopeCornerInverted", "Tritanium_SmallBlockArmorHalfSlopeCornerInverted" },
            {"SmallBlockArmorHalfSlopeInverted", "Tritanium_SmallBlockArmorHalfSlopeInverted" },

            // 2x1 Corner Slope
            {"SmallBlockArmorSlopedCornerTip", "Tritanium_SmallBlockArmorSlopedCornerTip" },
            {"SmallBlockArmorRaisedSlopedCorner", "Tritanium_SmallBlockArmorRaisedSlopedCorner" },
            {"SmallBlockArmorSquareSlopedCornerTip", "Tritanium_SmallBlockArmorSquareSlopedCornerTip" },
            {"SmallBlockArmorSquareSlopedCornerBase", "Tritanium_SmallBlockArmorSquareSlopedCornerBase" },
            {"SmallBlockArmorSquareSlopedCornerTipInv", "Tritanium_SmallBlockArmorSquareSlopedCornerTipInv" },
            {"SmallBlockArmorSlopedCornerBase", "Tritanium_SmallBlockArmorSlopedCornerBase" },
            {"SmallBlockArmorSlopedCorner", "Tritanium_SmallBlockArmorSlopedCorner" },
            {"SmallBlockArmorHalfSlopedCornerBase", "Tritanium_SmallBlockArmorHalfSlopedCornerBase" },

            // Round
            {"SmallBlockArmorRoundSlope", "Tritanium_SmallBlockArmorRoundSlope" },
            {"SmallBlockArmorRoundCorner", "Tritanium_SmallBlockArmorRoundCorner" },
            {"SmallBlockArmorRoundCornerInv", "Tritanium_SmallBlockArmorRoundCornerInv" },

            //
            // Large grid heavy armor
            //

            // Panels
            {"LargeArmorPanelHeavy", "LargeArmorPanelTritanium" },
            {"LargeArmorSlopedPanelHeavy", "LargeArmorSlopedPanelTritanium" },
            {"LargeArmorSlopedSidePanelHeavy", "LargeArmorSlopedSidePanelTritanium" },
            {"LargeArmor2x1SlopedPanelHeavy", "LargeArmor2x1SlopedPanelTritanium" },
            {"LargeArmor2x1SlopedPanelTipHeavy", "LargeArmor2x1SlopedPanelTipTritanium" },
            {"LargeArmor2x1SlopedSideBasePanelHeavy", "LargeArmor2x1SlopedSideBasePanelTritanium" },
            {"LargeArmor2x1SlopedSideTipPanelHeavy", "LargeArmor2x1SlopedSideTipPanelTritanium" },
            {"LargeArmor2x1SlopedSideBasePanelHeavyInv", "LargeArmor2x1SlopedSideBasePanelTritaniumInv" },
            {"LargeArmor2x1SlopedSideTipPanelHeavyInv", "LargeArmor2x1SlopedSideTipPanelTritaniumInv" },
            {"LargeArmorHalfSlopedPanelHeavy", "LargeArmorHalfSlopedPanelTritanium" },
            {"LargeArmor2x1HalfSlopedPanelHeavyRight", "LargeArmor2x1HalfSlopedPanelTritaniumRight" },
            {"LargeArmor2x1HalfSlopedTipPanelHeavyRight", "LargeArmor2x1HalfSlopedTipPanelTritaniumRight" },
            {"LargeArmor2x1HalfSlopedPanelHeavyLeft", "LargeArmor2x1HalfSlopedPanelTritaniumLeft" },
            {"LargeArmor2x1HalfSlopedTipPanelHeavyLeft", "LargeArmor2x1HalfSlopedTipPanelTritaniumLeft" },
            {"LargeArmorHalfCenterPanelHeavy", "LargeArmorHalfCenterPanelTritanium" },
            {"LargeArmorHalfPanelHeavy", "LargeArmorHalfPanelTritanium" },
            {"LargeArmorQuarterPanelHeavy", "LargeArmorQuarterPanelTritanium" },
            {"LargeArmorCenterPanelHeavy", "LargeArmorCenterPanelTritanium" },

            // Transitions
            {"LargeBlockHeavyArmorSlopeTransitionBase", "Tritanium_LargeBlockArmorSlopeTransitionBase" },
            {"LargeBlockHeavyArmorSlopeTransition", "Tritanium_LargeBlockArmorSlopeTransition" },
            {"LargeBlockHeavyArmorSlopeTransitionTip", "Tritanium_LargeBlockArmorSlopeTransitionTip" },
            {"LargeBlockHeavyArmorSlopeTransitionBaseMirrored", "Tritanium_LargeBlockArmorSlopeTransitionBaseMirrored" },
            {"LargeBlockHeavyArmorSlopeTransitionMirrored", "Tritanium_LargeBlockArmorSlopeTransitionMirrored" },
            {"LargeBlockHeavyArmorSlopeTransitionTipMirrored", "Tritanium_LargeBlockArmorSlopeTransitionTipMirrored" },

            // Cubes
            {"LargeHeavyBlockArmorBlock", "Tritanium_LargeBlockArmorBlock" },
            {"LargeHeavyBlockArmorSlope", "Tritanium_LargeBlockArmorSlope" },
            {"LargeHeavyBlockArmorCorner", "Tritanium_LargeBlockArmorCorner" },
            {"LargeHeavyBlockArmorCornerInv", "Tritanium_LargeBlockArmorCornerInv" },
            {"LargeBlockHeavyArmorCornerSquare", "Tritanium_LargeBlockArmorCornerSquare" },
            {"LargeBlockHeavyArmorCornerSquareInverted", "Tritanium_LargeBlockArmorCornerSquareInverted" },

            // 2x1
            {"LargeHeavyBlockArmorSlope2Base", "Tritanium_LargeBlockArmorSlope2Base" },
            {"LargeHeavyBlockArmorSlope2Tip", "Tritanium_LargeBlockArmorSlope2Tip" },
            {"LargeHeavyHalfArmorBlock", "Tritanium_LargeHalfArmorBlock" },
            {"LargeHeavyHalfSlopeArmorBlock", "Tritanium_LargeHalfSlopeArmorBlock" },
            {"LargeBlockHeavyArmorHalfSlopeCorner", "Tritanium_LargeBlockArmorHalfSlopeCorner" },
            {"LargeBlockHeavyArmorHalfCorner", "Tritanium_LargeBlockArmorHalfCorner" },
            {"LargeBlockHeavyArmorHalfSlopedCorner", "Tritanium_LargeBlockArmorHalfSlopedCorner" },

            // 2x1 Corner
            {"LargeHeavyBlockArmorCorner2Base", "Tritanium_LargeBlockArmorCorner2Base" },
            {"LargeHeavyBlockArmorCorner2Tip", "Tritanium_LargeBlockArmorCorner2Tip" },
            {"LargeHeavyBlockArmorInvCorner2Base", "Tritanium_LargeBlockArmorInvCorner2Base" },
            {"LargeHeavyBlockArmorInvCorner2Tip", "Tritanium_LargeBlockArmorInvCorner2Tip" },
            {"LargeBlockHeavyArmorHalfSlopeCornerInverted", "Tritanium_LargeBlockArmorHalfSlopeCornerInverted" },
            {"LargeBlockHeavyArmorHalfSlopeInverted", "Tritanium_LargeBlockArmorHalfSlopeInverted" },

            // 2x1 Corner Slope
            {"LargeBlockHeavyArmorSlopedCornerTip", "Tritanium_LargeBlockArmorSlopedCornerTip" },
            {"LargeBlockHeavyArmorRaisedSlopedCorner", "Tritanium_LargeBlockArmorRaisedSlopedCorner" },
            {"LargeBlockHeavyArmorSquareSlopedCornerTip", "Tritanium_LargeBlockArmorSquareSlopedCornerTip" },
            {"LargeBlockHeavyArmorSquareSlopedCornerBase", "Tritanium_LargeBlockArmorSquareSlopedCornerBase" },
            {"LargeBlockHeavyArmorSquareSlopedCornerTipInv", "Tritanium_LargeBlockArmorSquareSlopedCornerTipInv" },
            {"LargeBlockHeavyArmorSlopedCornerBase", "Tritanium_LargeBlockArmorSlopedCornerBase" },
            {"LargeBlockHeavyArmorSlopedCorner", "Tritanium_LargeBlockArmorSlopedCorner" },
            {"LargeBlockHeavyArmorHalfSlopedCornerBase", "Tritanium_LargeBlockArmorHalfSlopedCornerBase" },

            // Round
            {"LargeHeavyBlockArmorRoundSlope", "Tritanium_LargeBlockArmorRoundSlope" },
            {"LargeHeavyBlockArmorRoundCorner", "Tritanium_LargeBlockArmorRoundCorner" },
            {"LargeHeavyBlockArmorRoundCornerInv", "Tritanium_LargeBlockArmorRoundCornerInv" },

            //
            // Small grid heavy armor
            //

            // Panels
            {"SmallArmorPanelHeavy", "SmallArmorPanelTritanium" },
            {"SmallArmorSlopedPanelHeavy", "SmallArmorSlopedPanelTritanium" },
            {"SmallArmorSlopedSidePanelHeavy", "SmallArmorSlopedSidePanelTritanium" },
            {"SmallArmor2x1SlopedPanelHeavy", "SmallArmor2x1SlopedPanelTritanium" },
            {"SmallArmor2x1SlopedPanelTipHeavy", "SmallArmor2x1SlopedPanelTipTritanium" },
            {"SmallArmor2x1SlopedSideBasePanelHeavy", "SmallArmor2x1SlopedSideBasePanelTritanium" },
            {"SmallArmor2x1SlopedSideTipPanelHeavy", "SmallArmor2x1SlopedSideTipPanelTritanium" },
            {"SmallArmor2x1SlopedSideBasePanelHeavyInv", "SmallArmor2x1SlopedSideBasePanelTritaniumInv" },
            {"SmallArmor2x1SlopedSideTipPanelHeavyInv", "SmallArmor2x1SlopedSideTipPanelTritaniumInv" },
            {"SmallArmorHalfSlopedPanelHeavy", "SmallArmorHalfSlopedPanelTritanium" },
            {"SmallArmor2x1HalfSlopedPanelHeavyRight", "SmallArmor2x1HalfSlopedPanelTritaniumRight" },
            {"SmallArmor2x1HalfSlopedTipPanelHeavyRight", "SmallArmor2x1HalfSlopedTipPanelTritaniumRight" },
            {"SmallArmor2x1HalfSlopedPanelHeavyLeft", "SmallArmor2x1HalfSlopedPanelTritaniumLeft" },
            {"SmallArmor2x1HalfSlopedTipPanelHeavyLeft", "SmallArmor2x1HalfSlopedTipPanelTritaniumLeft" },
            {"SmallArmorHalfCenterPanelHeavy", "SmallArmorHalfCenterPanelTritanium" },
            {"SmallArmorHalfPanelHeavy", "SmallArmorHalfPanelTritanium" },
            {"SmallArmorQuarterPanelHeavy", "SmallArmorQuarterPanelTritanium" },
            {"SmallArmorCenterPanelHeavy", "SmallArmorCenterPanelTritanium" },

            // Transitions
            {"SmallBlockHeavyArmorSlopeTransitionBase", "Tritanium_SmallBlockArmorSlopeTransitionBase" },
            {"SmallBlockHeavyArmorSlopeTransition", "Tritanium_SmallBlockArmorSlopeTransition" },
            {"SmallBlockHeavyArmorSlopeTransitionTip", "Tritanium_SmallBlockArmorSlopeTransitionTip" },
            {"SmallBlockHeavyArmorSlopeTransitionBaseMirrored", "Tritanium_SmallBlockArmorSlopeTransitionBaseMirrored" },
            {"SmallBlockHeavyArmorSlopeTransitionMirrored", "Tritanium_SmallBlockArmorSlopeTransitionMirrored" },
            {"SmallBlockHeavyArmorSlopeTransitionTipMirrored", "Tritanium_SmallBlockArmorSlopeTransitionTipMirrored" },

            // Cubes
            {"SmallHeavyBlockArmorBlock", "Tritanium_SmallBlockArmorBlock" },
            {"SmallHeavyBlockArmorSlope", "Tritanium_SmallBlockArmorSlope" },
            {"SmallHeavyBlockArmorCorner", "Tritanium_SmallBlockArmorCorner" },
            {"SmallHeavyBlockArmorCornerInv", "Tritanium_SmallBlockArmorCornerInv" },
            {"SmallBlockHeavyArmorCornerSquare", "Tritanium_SmallBlockArmorCornerSquare" },
            {"SmallBlockHeavyArmorCornerSquareInverted", "Tritanium_SmallBlockArmorCornerSquareInverted" },

            // 2x1
            {"SmallHeavyBlockArmorSlope2Base", "Tritanium_SmallBlockArmorSlope2Base" },
            {"SmallHeavyBlockArmorSlope2Tip", "Tritanium_SmallBlockArmorSlope2Tip" },
            {"HeavyHalfArmorBlock", "Tritanium_HalfArmorBlock" },
            {"HeavyHalfSlopeArmorBlock", "Tritanium_HalfSlopeArmorBlock" },
            {"SmallBlockHeavyArmorHalfSlopeCorner", "Tritanium_SmallBlockArmorHalfSlopeCorner" },
            {"SmallBlockHeavyArmorHalfCorner", "Tritanium_SmallBlockArmorHalfCorner" },
            {"SmallBlockHeavyArmorHalfSlopedCorner", "Tritanium_SmallBlockArmorHalfSlopedCorner" },

            // 2x1 Corner
            {"SmallHeavyBlockArmorCorner2Base", "Tritanium_SmallBlockArmorCorner2Base" },
            {"SmallHeavyBlockArmorCorner2Tip", "Tritanium_SmallBlockArmorCorner2Tip" },
            {"SmallHeavyBlockArmorInvCorner2Base", "Tritanium_SmallBlockArmorInvCorner2Base" },
            {"SmallHeavyBlockArmorInvCorner2Tip", "Tritanium_SmallBlockArmorInvCorner2Tip" },
            {"SmallBlockHeavyArmorHalfSlopeCornerInverted", "Tritanium_SmallBlockArmorHalfSlopeCornerInverted" },
            {"SmallBlockHeavyArmorHalfSlopeInverted", "Tritanium_SmallBlockArmorHalfSlopeInverted" },

            // 2x1 Corner Slope
            {"SmallBlockHeavyArmorSlopedCornerTip", "Tritanium_SmallBlockArmorSlopedCornerTip" },
            {"SmallBlockHeavyArmorRaisedSlopedCorner", "Tritanium_SmallBlockArmorRaisedSlopedCorner" },
            {"SmallBlockHeavyArmorSquareSlopedCornerTip", "Tritanium_SmallBlockArmorSquareSlopedCornerTip" },
            {"SmallBlockHeavyArmorSquareSlopedCornerBase", "Tritanium_SmallBlockArmorSquareSlopedCornerBase" },
            {"SmallBlockHeavyArmorSquareSlopedCornerTipInv", "Tritanium_SmallBlockArmorSquareSlopedCornerTipInv" },
            {"SmallBlockHeavyArmorSlopedCornerBase", "Tritanium_SmallBlockArmorSlopedCornerBase" },
            {"SmallBlockHeavyArmorSlopedCorner", "Tritanium_SmallBlockArmorSlopedCorner" },
            {"SmallBlockHeavyArmorHalfSlopedCornerBase", "Tritanium_SmallBlockArmorHalfSlopedCornerBase" },

            // Round
            {"SmallHeavyBlockArmorRoundSlope", "Tritanium_SmallBlockArmorRoundSlope" },
            {"SmallHeavyBlockArmorRoundCorner", "Tritanium_SmallBlockArmorRoundCorner" },
            {"SmallHeavyBlockArmorRoundCornerInv", "Tritanium_SmallBlockArmorRoundCornerInv" },

            //
            // Windows
            //

            //
            // Miscellaneous
            //
        };

        public string Convert(string block)
        {
            return BlockMap.GetValueOrDefault(block);
        }
    }
}
