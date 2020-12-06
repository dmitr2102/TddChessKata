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

        public void WhenTryCreatingElephantOnE9_ThenItThrowsArgumentException()
        {

        }
    }
}