using PracticeAssignment1;
using Xunit.Abstractions;

namespace Car1Tests
{
    public class Car ITest
    { 
        {
        [Fact]
    public void CreateNewCarTest()
    {
        //arrange & act
        var car = new Car();

            //assert
            Assert.NotNull(car);
        }
    }
}