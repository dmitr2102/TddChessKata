namespace TddChessEngineLib
{
    public class Elephant
    {
        public Vector2 stPos { get; private set; }

        public Elephant(Vector2 startPosition){
            if (startPosition.h > 0 && startPosition.h < 9 && (int)startPosition.w < 9 &&  (int)startPosition.w > 0)
                stPos = startPosition;
            else throw new System.ArgumentException("Position overflow");
        }

        public Vector2 Turn(Vector2 endPos)
        {
            if (endPos.w == stPos.w)
            {
                stPos.h = endPos.h;
            }
            else
            {
                throw new System.ArgumentException("end position don't equal start position");
            }

            return stPos;
        }
    }
}