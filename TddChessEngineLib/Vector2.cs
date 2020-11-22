using System.Numerics;
namespace TddChessEngineLib
{
    public class Vector2
    {
        public int h;
        public Width w;

        public Vector2(Width W, int H)
        {
            h = H;
            w = W;
        }
    }

    public enum Width{
        A = 1, B = 2, C = 3, D = 4, E = 5, F = 6, G = 7, H = 8
    }
}