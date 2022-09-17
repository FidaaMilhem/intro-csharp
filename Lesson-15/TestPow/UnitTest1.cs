namespace TestPow
{
    [TestClass]
    public class UnitTest1
    {
        Data.Algebra r;
        [TestMethod]
        public void TestMethod1()
        {
            r = new Data.Algebra();
        }

        [TestMethod]
        public void TestPowerzero()
        {
            int[] n = {0,1,2,3};
            //var re = r.Pow(10, 0);
            //Assert.AreEqual(50, re);
            for (int i = 0; i < n.Length; i++)
            {
                var res = r.Pow(n[i], 0);
                Assert.AreEqual(1, res);
            }
        }

        [TestMethod]
        public void TestPowerby()
        {
            int[] n = { 0, 1, 2, 3 };
            //var re = r.Pow(10, 0);
            //Assert.AreEqual(50, re);
            for (int i = 0; i < n.Length; i++)
            {
                var res = r.Pow(n[i], 0);
                Assert.AreEqual(1, res);
            }
        }


    }
}