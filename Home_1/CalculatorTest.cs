/*using Home_1.Calc;

namespace Home_1
{
    public class CalculatorTest:BaseTest
    {

        [Test(Description = "Sum")]
        public void Test1()
        {
            var expected = 4;
            var actual = calculator.Add(2, 2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test(Description = "Sum random")]
        [Retry(10)]
        [Category("Smoke")]
        [Description("Random value")]

        public void SumRandom(
                    [Random(0, 10, 1)] double operand1,
                    [Random(0, 10, 1)] double operand2)

        {
            var expected = 4;
            var actual = calculator.Add(operand1, operand2);
            Assert.That(actual, Is.EqualTo(expected));
        }        
        
        [Test(Description = "Sum random")]
        [Retry(10)]
        [Category("Smoke")]
        [Description("Random value")]

        public void Sum_Random(
                    [Random(0, 10, 1)] double operand1,
                    [Random(0, 10, 1)] double operand2)

        {
            var expected = 4;
            var actual = calculator.Add(operand1, operand2);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}*/