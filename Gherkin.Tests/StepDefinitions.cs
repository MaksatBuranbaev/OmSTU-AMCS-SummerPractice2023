namespace Gherkin.Tests;
using TechTalk.SpecFlow;
using SquareEquationLib;

[Binding]
public class SquareEquationBDD
{
    private Exception _actualException = new Exception ();
   [Then("выбрасывается исключение ArgumentException")]
    public void ThrowingArgumentException()
    {
        Assert.ThrowsAsync<ArgumentException>(() => throw _actualException);
    }

    [When(@"вычисляются корни квадратного уравнения")]
         public void КогдаВычисляютсяКорниКвадратногоУравнения()
         {
             _scenarioContext.Pending();
         }
    
    [Given(@"Квадратное уравнение с коэффициентами \(NaN, (.*), (.*)\)")]
         public void ДопустимКвадратноеУравнениеСКоэффициентамиNaN(int p0, int p1)
         {
             _scenarioContext.Pending();
         }
    
    [When(@"вычисляются корни квадратного уравнения")]
         public void КогдаВычисляютсяКорниКвадратногоУравнения()
         {
             _scenarioContext.Pending();
         }
        
    [Given(@"Квадратное уравнение с коэффициентами \((.*), (.*), Double\.PositiveInfinity\)")]
         public void ДопустимКвадратноеУравнениеСКоэффициентамиDouble_PositiveInfinity(int p0, int p1)
         {
             _scenarioContext.Pending();
         }

    [When(@"вычисляются корни квадратного уравнения")]
         public void КогдаВычисляютсяКорниКвадратногоУравнения()
         {
             _scenarioContext.Pending();
         }

    [Given(@"Квадратное уравнение с коэффициентами \((.*), (.*), Double\.NegativeInfinity\)")]
         public void ДопустимКвадратноеУравнениеСКоэффициентамиDouble_NegativeInfinity(int p0, int p1)
         {
             _scenarioContext.Pending();
         }
    
    [When(@"вычисляются корни квадратного уравнения")]
         public void КогдаВычисляютсяКорниКвадратногоУравнения()
         {
             _scenarioContext.Pending();
         }

    [Given(@"Квадратное уравнение с коэффициентами \(Double\.NegativeInfinity, (.*), (.*)\)")]
         public void ДопустимКвадратноеУравнениеСКоэффициентамиDouble_NegativeInfinity(int p0, int p1)
         {
             _scenarioContext.Pending();
         }

    [When(@"вычисляются корни квадратного уравнения")]
         public void КогдаВычисляютсяКорниКвадратногоУравнения()
         {
             _scenarioContext.Pending();
         }

    [Given(@"Квадратное уравнение с коэффициентами \(Double\.PositiveInfinity, (.*), (.*)\)")]
         public void ДопустимКвадратноеУравнениеСКоэффициентамиDouble_PositiveInfinity(int p0, int p1)
         {
             _scenarioContext.Pending();
         }
        
    [When(@"вычисляются корни квадратного уравнения")]
         public void КогдаВычисляютсяКорниКвадратногоУравнения()
         {
             _scenarioContext.Pending();
         }

    [Given(@"Квадратное уравнение с коэффициентами \((.*)e(.*), (.*), (.*)\)")]
         public void ДопустимКвадратноеУравнениеСКоэффициентамиE(int p0, int p1, int p2, int p3)
         {
             _scenarioContext.Pending();
         }

    [When(@"вычисляются корни квадратного уравнения")]
         public void КогдаВычисляютсяКорниКвадратногоУравнения()
         {
             _scenarioContext.Pending();
         }

    [Given(@"Квадратное уравнение с коэффициентами \((.*), (.*), NaN\)")]
         public void ДопустимКвадратноеУравнениеСКоэффициентамиNaN(int p0, int p1)
         {
             _scenarioContext.Pending();
         }

    [Then(@"квадратное уравнение имеет два корня \((.*), (.*)\) кратности один")]
         public void ТоКвадратноеУравнениеИмеетДваКорняКратностиОдин(int p0, int p1)
         {
             _scenarioContext.Pending();
         }

    [When(@"вычисляются корни квадратного уравнения")]
         public void КогдаВычисляютсяКорниКвадратногоУравнения()
         {
             _scenarioContext.Pending();
         }

    [Given(@"Квадратное уравнение с коэффициентами \((.*), (.*), (.*)\)")]
         public void ДопустимКвадратноеУравнениеСКоэффициентами(int p0, int p1, int p2)
         {
             _scenarioContext.Pending();
         }

    [When(@"вычисляются корни квадратного уравнения")]
         public void КогдаВычисляютсяКорниКвадратногоУравнения()
         {
             _scenarioContext.Pending();
         }

    [Given(@"Квадратное уравнение с коэффициентами \((.*), Double\.NegativeInfinity, (.*)\)")]
         public void ДопустимКвадратноеУравнениеСКоэффициентамиDouble_NegativeInfinity(int p0, int p1)
         {
             _scenarioContext.Pending();
         }

    [Then(@"квадратное уравнение имеет один корень (.*) кратности два")]
         public void ТоКвадратноеУравнениеИмеетОдинКореньКратностиДва(int p0)
         {
             _scenarioContext.Pending();
         }

    [When(@"вычисляются корни квадратного уравнения")]
         public void КогдаВычисляютсяКорниКвадратногоУравнения()
         {
             _scenarioContext.Pending();
         }

    [Given(@"Квадратное уравнение с коэффициентами \((.*), (.*), (.*)\)")]
         public void ДопустимКвадратноеУравнениеСКоэффициентами(int p0, int p1, int p2)
         {
             _scenarioContext.Pending();
         }

    [When(@"вычисляются корни квадратного уравнения")]
         public void КогдаВычисляютсяКорниКвадратногоУравнения()
         {
             _scenarioContext.Pending();
         }

    [Given(@"Квадратное уравнение с коэффициентами \((.*), Double\.PositiveInfinity, (.*)\)")]
         public void ДопустимКвадратноеУравнениеСКоэффициентамиDouble_PositiveInfinity(int p0, int p1)
         {
             _scenarioContext.Pending();
         }

    [Then(@"множество корней квадратного уравнения пустое")]
         public void ТоМножествоКорнейКвадратногоУравненияПустое()
         {
             _scenarioContext.Pending();
         }

    [When(@"вычисляются корни квадратного уравнения")]
         public void КогдаВычисляютсяКорниКвадратногоУравнения()
         {
             _scenarioContext.Pending();
         }

    [Given(@"Квадратное уравнение с коэффициентами \((.*), (.*), (.*)\)")]
         public void ДопустимКвадратноеУравнениеСКоэффициентами(int p0, int p1, int p2)
         {
             _scenarioContext.Pending();
         }

    [When(@"вычисляются корни квадратного уравнения")]
         public void КогдаВычисляютсяКорниКвадратногоУравнения()
         {
             _scenarioContext.Pending();
         }

    [Given(@"Квадратное уравнение с коэффициентами \((.*), NaN, (.*)\)")]
         public void ДопустимКвадратноеУравнениеСКоэффициентамиNaN(int p0, int p1)
         {
             _scenarioContext.Pending();
         }
}