namespace Gherkin.Tests;
using TechTalk.SpecFlow;
using SquareEquationLib;

[Binding]
public class SquareEquationBDD
{
    private double a, b, c;
    private double[] actualResult = new double[0]; 
    private Exception actualException = new Exception();

    [Given(@"Квадратное уравнение с коэффициентами \((.*), (.*), (.*)\)")]
    public void ДопустимКвадратноеУравнениеСКоэффициентами(string p0, string p1, string p2)
         {
            string[] val = {p0, p1, p2};
            double[] valDouble = new double[val.Length];

            for (int i = 0; i < val.Length; i++)
            {
                if(val[i] == "NaN")
                {
                    valDouble[i] = double.NaN;
                }

                else if(val[i] == "Double.NegativeInfinity")
                {
                    valDouble[i] = double.NegativeInfinity;
                }

                else if(val[i] == "Double.PositiveInfinity")
                {
                    valDouble[i] = double.PositiveInfinity;
                }

                else
                {
                    valDouble[i] = double.Parse(val[i]);
                }
            } 

            a = valDouble[0]; b = valDouble[1]; c = valDouble[2];
         }

    [When(@"вычисляются корни квадратного уравнения")]
    public void КогдаВычисляютсяКорниКвадратногоУравнения()
         {
            try
            {
                actualResult = SquareEquation.Solve(a, b, c);
            }
            catch(Exception e)
            {
                actualException = e;
            }
         }

    [Then(@"квадратное уравнение имеет два корня \((.*), (.*)\) кратности один")]
    public void ТоКвадратноеУравнениеИмеетДваКорняКратностиОдин(double p0, double p1)
         {
             double[] expectedResult = new double[] {p0, p1};
        
            Array.Sort(expectedResult);
            Array.Sort(actualResult);

            if (actualResult.Length != 2)
            {
                Assert.Fail("");
            }

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(actualResult[i], expectedResult[i]);
            }
        }

    [Then(@"квадратное уравнение имеет один корень (.*) кратности два")]
    public void ТоКвадратноеУравнениеИмеетОдинКореньКратностиДва(double p0)
         {
            double[] expectedResult = new double[] {p0};
        
            if (actualResult.Length != 1)
            {
                Assert.Fail("");
            }

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(actualResult[i], expectedResult[i]);
            }
         }

    [Then(@"множество корней квадратного уравнения пустое")]
    public void ТоМножествоКорнейКвадратногоУравненияПустое()
         {
            Assert.Empty(actualResult);
         }

    [Then(@"выбрасывается исключение ArgumentException")]
         public void ТоВыбрасываетсяИсключениеArgumentException()
         {
            Assert.ThrowsAsync<ArgumentException>(() => SquareEquation.Solve(a, b, c));
         }
}