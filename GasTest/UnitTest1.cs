namespace GasTest
{
    public class CarGasTest1
    {
        //[Fact]
        [TestMethod]
        public void TestGasTankAfterDriving()
        {
            {
                test_car.Drive(10);
                Assert.AreEqual(9, test_car.GasTankLevel, .001);
            }

        }
    }
}



