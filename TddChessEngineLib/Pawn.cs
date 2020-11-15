using System.Numerics;
using System;

namespace TddChessEngineLib
{
    public class Pawn
    {
        public Vector2 stPos { get; private set; }

        public Pawn(Vector2 StartPosition)
        {
            stPos = StartPosition;
        }

        public Vector2 Turn(Vector2 startPosition, Vector2 finalPosition)
        {
            if(startPosition == stPos)
            {
                stPos = finalPosition;
                return finalPosition;
            }
            else{
                return startPosition;
            }
        }
    }
}
