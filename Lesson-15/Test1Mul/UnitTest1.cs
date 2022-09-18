namespace TestMul
{
    public class Tests
    {
        Data.Algebra r;

        [SetUp]
        public void Setup()
        {
            r = new Data.Algebra();
        }

        [Test]
        public void TestMulby0()
        {
            int[] a = { 0, 1, 2, 3 };
            for (int i = 0; i < a.Length; i++)
            {
                var res = r.Mul(a[i], 0);
                Assert.AreEqual(0, res);
            }

        }

        [Test]
        public void TestMulby1()
        {
            int[] a = { 1, 2, 3 };
            for (int i = 0; i < a.Length; i++)
            {
                var res = r.Mul(a[i], 1);
                Assert.AreEqual(a[i], res);
            }

        }

        [Test]
        public void TestMulpositive()
        {
            int[] a = { 1, 1, 2, 3, 4 };
            int[] b = { 5, 6, 7, 8, 9 };
            for (int i = 0; i < a.Length; i++)
            {
                var res = r.Mul(a[i], b[i]);
                Assert.AreEqual(a[i] * b[i], res);
            }

        }

        [Test]
        public void TestMulnegative()
        {
            int[] a = { 6, 1, -2, 3 };
            int[] b = { 2, -1, -5, 3 };
            for (int i = 0; i < a.Length; i++)
            {
                var res = r.Mul(a[i], b[i]);
                Assert.AreEqual(a[i] * b[i], res);
            }

        }
    }
}