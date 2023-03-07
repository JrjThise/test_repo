namespace xUnitTestTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string test = "hej";
            Assert.Contains("hej", test);
        }
    }
}