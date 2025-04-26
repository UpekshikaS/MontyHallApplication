using MontyHallApplication.Server;
using MontyHallApplication.Server.Services;

namespace MontyHallSimulationTests
{
    public class UnitTest1
    {
        [Fact]
        public void SwitchingDoor_ShouldHaveHigherWinRate()
        {
            var simulator = new MontyHallSimulator();

            var resultSwitch = simulator.RunSimulations(10000, true);
            var resultNoSwitch = simulator.RunSimulations(10000, false);

            Assert.True(resultSwitch.wins > resultNoSwitch.wins);
        }
    }
}