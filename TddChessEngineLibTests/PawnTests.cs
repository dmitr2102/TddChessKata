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
            Pawn pawn = new Pawn(new Vector2(Width.E, 2), FigureCollor.White);

            Assert.Equal(pawn.Turn(pawn.stPos, new Vector2(Width.E, 3)), new Vector2(Width.E, 3));
        }


    }
}
