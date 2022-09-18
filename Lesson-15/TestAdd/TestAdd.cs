
namespace TestAdd
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
        public void TestAddPositive()
        {
            var sol = r.Add(2, 3);
            Assert.AreEqual(5, sol);
        }


        [Test]
        public void TestAddNegativ()
        {
            var sol = r.Add(-2, -3);
            Assert.AreEqual(-5, sol);
        }

        [Test]
        public void TestAddZero()
        {
            int x = 0;
            int y = 0;
            var sol = r.Add(x, y);
            Assert.AreEqual(x + y, sol);
        }

        [Test]
        public void TestAddLists()
        {
            int[] a = { 6, 1, 2, 3 };
            int[] b = { 0, -1, -5, 3 };
            for (int i = 0; i < a.Length; i++)
            {
                var sol = r.Add(a[i], b[i]);
                Assert.AreEqual(a[i] + b[i], sol);
            }

        }


    }

}