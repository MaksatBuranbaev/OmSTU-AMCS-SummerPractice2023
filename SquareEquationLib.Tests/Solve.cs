using SquareEquationLib;

namespace SquareEquationLib.Tests
{
    public class SquareEquationLib_Test
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(double.PositiveInfinity, 1, 1)]
        [InlineData(1, double.PositiveInfinity, 1)]
        [InlineData(1, 1, double.PositiveInfinity)]
        [InlineData(double.NaN, 1, 1)]
        [InlineData(1, double.NaN, 1)]
        [InlineData(1, 1, double.NaN)]
        public void Solve_InputIncVal_ReturnArgumentException(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => SquareEquation.Solve(a, b, c));
        }

        [Theory]
        [InlineData(1, 3, -4, new double[]{-4, 1})]
        [InlineData(1, 0, -1, new double[] {-1, 1})]
        [InlineData(1,-4, 4, new double[] {2})]
        [InlineData(1, -5, 9, new double[]{})]
        public void Solve_InputCorVal_ReturnDoubleArray(double a, double b, double c, double[] expected)
        {
            var actual = SquareEquation.Solve(a, b, c);
            
            Array.Sort(actual);
            Array.Sort(expected);

            if (actual.Length != expected.Length) Assert.Fail("The number of roots does not match");
        
            for (int i = 0; i < actual.Length;i++){
                Assert.Equal(expected[i], actual[i], 6);
            }
        }
    }
}