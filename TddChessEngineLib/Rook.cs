namespace TddChessEngineLib
{
    public class Rook
    {
        public Vector2 stPos { get; private set; }

        public Rook(Vector2 startPosition)
        {
            if (startPosition.h > 0 && startPosition.h < 9 && (int)startPosition.w < 9 &&  (int)startPosition.w > 0)
                stPos = startPosition;
            else throw new System.ArgumentException("Not start position");
        }
    }
}