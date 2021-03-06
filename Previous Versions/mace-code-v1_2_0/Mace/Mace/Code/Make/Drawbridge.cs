﻿/*
    Mace
    Copyright (C) 2011 Robson
    http://iceyboard.no-ip.org

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using Substrate;
using Substrate.TileEntities;

namespace Mace
{
    class Drawbridge
    {
        public static void MakeDrawbridges(BlockManager bm, int intFarmSize, int intMapSize, bool booIncludeMoat, bool booIncludeWalls)
        {
            if (booIncludeWalls)
            {
                // drawbridge
                int intBridgeEnd = booIncludeMoat ? -2 : 5;
                BlockShapes.MakeSolidBox((intMapSize / 2) - 2, intMapSize / 2, 63, 63,
                                            intFarmSize + intBridgeEnd, intFarmSize + 11, (int)BlockType.STONE, 2);
                // carve out the entrance/exit
                BlockShapes.MakeSolidBox((intMapSize / 2) - 2, intMapSize / 2, 64, 67,
                                         intFarmSize + 6, intFarmSize + 10, (int)BlockType.AIR, 2);
                // add the bottom of a portcullis
                BlockShapes.MakeSolidBox((intMapSize / 2) - 2, intMapSize / 2, 67, 67,
                                         intFarmSize + 6, intFarmSize + 6, (int)BlockType.FENCE, 2);
                // add room for murder holes
                BlockShapes.MakeSolidBox((intMapSize / 2) - 2, (intMapSize / 2) + 2, 69, 70,
                                         intFarmSize + 8, intFarmSize + 9, (int)BlockType.AIR, 2);
                BlockShapes.MakeSolidBox(intMapSize / 2, intMapSize / 2, 69, 71,
                                         intFarmSize + 8, intFarmSize + 9, (int)BlockType.AIR, 2);
                BlockHelper.MakeLadder(intMapSize / 2, 69, 71, intFarmSize + 9, 2);
                BlockShapes.MakeSolidBox(intMapSize / 2, intMapSize / 2, 71, 71,
                                         intFarmSize + 8, intFarmSize + 8, (int)BlockType.STONE, 2);
                // murder holes
                BlockShapes.MakeSolidBox((intMapSize / 2) - 2, (intMapSize / 2) - 2, 68, 68,
                                         intFarmSize + 8, intFarmSize + 8, (int)BlockType.AIR, 2);
                BlockShapes.MakeSolidBox(intMapSize / 2, intMapSize / 2, 68, 68,
                                         intFarmSize + 8, intFarmSize + 8, (int)BlockType.AIR, 2);
                BlockShapes.MakeSolidBox((intMapSize / 2) + 2, (intMapSize / 2) + 2, 68, 68,
                                         intFarmSize + 8, intFarmSize + 8, (int)BlockType.AIR, 2);
                // chests
                BlockShapes.MakeBlock((intMapSize / 2) - 4, 69, intFarmSize + 9, (int)BlockType.GRAVEL, 2);
                BlockShapes.MakeBlock((intMapSize / 2) + 4, 69, intFarmSize + 9, (int)BlockType.GRAVEL, 2);
                BlockShapes.MakeBlock((intMapSize / 2) - 3, 70, intFarmSize + 9, (int)BlockType.AIR, 2);
                BlockShapes.MakeBlock((intMapSize / 2) + 3, 70, intFarmSize + 9, (int)BlockType.AIR, 2);
                TileEntityChest tec = new TileEntityChest();
                tec.Items[0] = BlockHelper.MakeItem(ItemInfo.LavaBucket.ID);
                tec.Items[1] = BlockHelper.MakeItem(ItemInfo.LavaBucket.ID);
                tec.Items[2] = BlockHelper.MakeItem(ItemInfo.LavaBucket.ID);
                BlockHelper.MakeChest((intMapSize / 2) - 3, 69, intFarmSize + 9, (int)BlockType.GRAVEL, tec, 2);
                // add torches
                BlockHelper.MakeTorch((intMapSize / 2) - 1, 70, intFarmSize + 9, (int)BlockType.STONE, 2);
                BlockHelper.MakeTorch((intMapSize / 2) + 1, 70, intFarmSize + 9, (int)BlockType.STONE, 2);
            }
            else if (booIncludeMoat)
            {
                BlockShapes.MakeSolidBox((intMapSize / 2) - 2, intMapSize / 2, 63, 63,
                                            intFarmSize - 2, intFarmSize + 6, (int)BlockType.STONE, 2);
            }
        }
    }
}
