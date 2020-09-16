﻿using System;
using SimpleChess;

namespace Oblig_2
{
    public class Bishop : Piece
    {
        public override bool Move(string fromPosition, string toPosition)
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];
            return Math.Abs(diffRow) == Math.Abs(diffCol);
        }

        public Bishop(string symbol) : base(symbol)
        {
        }
    }
}