using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class PawnTests
    {
        [Fact]
        public void WhenPawnTurnsFromE2ToE4_ThenItsPositionsChanges()
        {
            Pawn pawn = new Pawn(new Vector2("E", 2));

            Assert.Equal(pawn.Turn(pawn.stPos, new Vector2("E", 4)), new Vector2("E", 4));
        }
    }
}
