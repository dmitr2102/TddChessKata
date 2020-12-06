using System.Drawing;
using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class PawnTests
    {
        [Fact]
        public void WhenPawnTurnsFromE2ToE3_ThenItsPositionsChanges()
        {
            Vector2 startPosition = new Vector2(Width.E, 2);
            Vector2 finalPosition = new Vector2(Width.E, 3);

            Pawn pawn = new Pawn(startPosition, FigureCollor.White);

            pawn.Turn(startPosition, finalPosition);

            Assert.Equal(pawn.stPos, finalPosition);

            //Assert.Throws<ArgumentException>(() => pawn.Turn(startPosition, finalPosition));
        }

        [Fact]
        public void WhenBlackPawnTriesGoBack_ThenItsCantGoBack()
        {
            Vector2 startPosition = new Vector2(Width.A, 1);
            Vector2 finalPosition = new Vector2(Width.A, 2);
            Pawn pawn = new Pawn(startPosition, FigureCollor.Black);

            pawn.Turn(startPosition, finalPosition);

            Assert.Equal(pawn.stPos, startPosition);
        }

        [Fact]
        public void WhenWhitePawnTriesGoBack_ThenItsCantGoBack()
        {
            Vector2 startPosition = new Vector2(Width.A, 2);
            Vector2 finalPosition = new Vector2(Width.A, 1);
            Pawn pawn = new Pawn(startPosition, FigureCollor.White);

            pawn.Turn(startPosition, finalPosition);

            Assert.Equal(pawn.stPos, startPosition);
        }

        [Fact]
        public void WhenWhitePawnTurnsFromE3ToE5_ThenItsCantJump()
        {
            Vector2 startPosition = new Vector2(Width.E, 2);
            Vector2 finalPosition = new Vector2(Width.E, 4);
            Pawn pawn = new Pawn(startPosition, FigureCollor.White);

            pawn.Turn(startPosition, finalPosition);

            Assert.Equal(pawn.stPos, finalPosition);
        }
    }
}
