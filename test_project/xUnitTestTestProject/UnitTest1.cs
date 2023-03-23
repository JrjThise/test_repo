namespace xUnitTestTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string test = "hej";
            Assert.Contains("world", test);
        }

        [Fact] public void Test2()
        {
            int expected = 10;
            int actual = 5 + 5;

            Assert.Equal(expected, actual);
        }
    }
}