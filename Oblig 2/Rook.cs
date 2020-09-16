using System;
using SimpleChess;

namespace Oblig_2
{
    public class Rook : Piece
    {

        public override bool Move(string fromPosition, string toPosition)
        {
            return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
        }

        public Rook(string symbol) : base(symbol)
        {
        }
    }
}