using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class ElephantTests
    {
        [Fact]
        public void WhenCreatingElephantOnE2_ThenItCurrentPositionE2()
        {
            var startPosition = new Vector2(Width.E, 2);
            Elephant elephant = new Elephant(startPosition);
            Assert.Equal(elephant.stPos, startPosition);
        }

        [Fact]
        public void WhenTryCreatingElephantOnE9_ThenItThrowsArgumentException()
        {
            var startPosition = new Vector2(Width.E, 9);

            Assert.Throws<ArgumentException>(() => new Elephant(startPosition));
        }

        [Fact]
        public void WhenTryCreatingElephantOnP2_ThenItThrowsArgumentException()
        {
            
            Assert.Throws<ArgumentException>(() => new Elephant(new Vector2(Width.E, 2)));
        }
        
        [Fact]
        public void WhenElephantTurnFromE2ToE3_ThenItThrowsArgumentException()
        {
            var startPosition = new Vector2(Width.E, 2);
            var endPosition = new Vector2(Width.E, 3);
            Elephant elephant = new Elephant(startPosition);
            elephant.Turn(endPosition);

            Assert.Equal(elephant.stPos, endPosition);
        }

        [Fact]
        public void WhenElephantTurnFromE2ToF3_ThenItChangesPosition()
        {
            var startPosition = new Vector2(Width.E, 2);
            Elephant elephant = new Elephant(startPosition);
        }
    }
}