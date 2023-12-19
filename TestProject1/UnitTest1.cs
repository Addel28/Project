using Project;
using Xunit;
//using Allure.Xunit;
//using Allure.Commons;
//using Allure.Xunit.Attributes;
namespace TestProject1
{
    [Collection("MyCollection")]
    public class UnitTest1
    {
        //[AllureLink("https://example.com/issue/1234")]
        //[AllureSeverity((Allure.Net.Commons.SeverityLevel)SeverityLevel.normal)]
        //[AllureOwner("Artemka")]
        [Xunit.Fact]
        public void Clear()
        {
            Project.Form1 form = new Project.Form1();
            //int y = 2;
            //double expected = 5;
            //double result = form.Asd(y);
            //Xunit.Assert.Equal(expected, result);
            int y = 1;
            int result = form.Asd(1);
            Xunit.Assert.Equal(y, result);
        }



    //    public class UnitTest1
    //{
    //    [Fact]
    //    public void Test1()
    //    {

    //    }
    }
}