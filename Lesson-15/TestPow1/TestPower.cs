namespace TestPow1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPowerby0()
        {
            var r = new Data.Algebra();
            int[] a = { 0,1, 2, 3 };
            for (int i = 0; i < a.Length; i++)
            {
                var res = r.Pow(a[i], 0);
                Assert.AreEqual(1, res);
            }
        }

        [TestMethod]
        public void TestPowerby1()
        {
            var r = new Data.Algebra();
            int[] a = { 0, -1, 2, 3 };
            for (int i = 0; i < a.Length; i++)
            {
                var res = r.Pow(a[i], 1);
                Assert.AreEqual(a[i], res);
            }
        }

        [TestMethod]
        public void TestMulpositive()
        {
            var r = new Data.Algebra();
            int[] a = { 1, 1, 2, 3, 4 };
            int[] b = { 5, 6, 7, 8, 9 };
            for (int i = 0; i < a.Length; i++)
            {
                var res = r.Pow(a[i], b[i]);
                Assert.AreEqual(Math.Pow(a[i] , b[i]), res);
            }

        }

        [TestMethod]
        public void TestNegativePower()
        {
            var r = new Data.Algebra();
            int[] a = { 1, 1, 2, 3, 4 };
            int[] b = { -5, -6, -7, -8, -9 };
            for (int i = 0; i < a.Length; i++)
            {
                double res = r.Pow(a[i], b[i]);
                Assert.AreEqual(Math.Pow(a[i], b[i]), res);
            }

        }

        [TestMethod]
        public void TestMixNumberAndPower()
        {
            var r = new Data.Algebra();
            int[] a = { 0, -1,2,-3 };
            int[] b = { 0, 0,-2,-3 };
            for (int i = 0; i < a.Length; i++)
            {
                double res = r.Pow(a[i], b[i]);
                Assert.AreEqual(Math.Pow(a[i], b[i]), res);
            }

        }


    }
}