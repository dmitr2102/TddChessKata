using System.Drawing;
using System.Numerics;
using System;

namespace TddChessEngineLib
{
    public class Pawn
    {
        public Vector2 stPos { get; private set; }

        public FigureCollor FigureCollor{get; set;}

        public Pawn(Vector2 StartPosition, FigureCollor color)
        {
            stPos = StartPosition;
            FigureCollor = color;
        }



        //Возможности первого хода
        //1. Есть ли кто-то в точке назначения
        //2. Границы карты
        //3. Направление
        //4. Ввести переменную сходила ли пешка или нет
        //5. (пока за скобами) Жива или нет
        //6. Длина шага 2 или 1

        public Vector2 Turn(Vector2 startPosition, Vector2 finalPosition)
        {
            if(startPosition == stPos)
            {
                if(finalPosition.h - stPos.h == 1 && (int)finalPosition.w - (int)startPosition.w == 0)
                {
                    Console.WriteLine(stPos.h);
                    stPos = finalPosition;
                    Console.WriteLine(stPos.h);
                    return finalPosition;
                }
                else{
                    return startPosition;
                }

            }
            else{
                return startPosition;
            }
        }
    }

    public enum FigureCollor
    {
        White, 
        Black
    }
}
