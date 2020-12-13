using System.Reflection;
using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class RookTest
    {
        [Fact]
        public void WhenTryCreatingRookOnA1_ThenItThrowsArgumentException()
        {
            var startPosition = new Vector2(Width.A, 1);
            Rook rook = new Rook(startPosition);
            Assert.Equal(rook.stPos, startPosition);
        }
        [Fact]
        public void WhenTryCreatingRookOnA10_ThenItThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Rook(new Vector2(Width.A, 10)));
        }   
        [Fact]
        public void WhenRookTurnFromA1ToA6_ThenItThrowsArgumentException()
        {
            var startPosition = new Vector2(Width.A, 1);
            var endPosition = new Vector2(Width.A, 6);
        }
    }
}