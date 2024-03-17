using AstroidaCalc;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<doublePoint> points = Astroida.CalcGraph(100, 2.0f);

            double leftLimit = -1;
            double rightLimit = 1;

            bool entersectionFlag  = false;

            for (int i = 0; i < points.Count - 1; ++i)
            {
                if (points[i].x > leftLimit && points[i].x < rightLimit && points[i+1].x > leftLimit && points[i+1].x < rightLimit)
                {
                    entersectionFlag = true;
                }
            }

            Assert.AreEqual(true, entersectionFlag);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<doublePoint> points = Astroida.CalcGraph(100, 2.0f);

            double leftLimit = 1;
            double rightLimit = 1;

            bool entersectionFlag = false;

            for (int i = 0; i < points.Count - 1; ++i)
            {
                if (points[i].x > leftLimit && points[i].x < rightLimit && points[i + 1].x > leftLimit && points[i + 1].x < rightLimit)
                {
                    entersectionFlag = true;
                }
            }

            Assert.AreEqual(false, entersectionFlag);
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<doublePoint> points = Astroida.CalcGraph(100, 3.0f);

            double leftLimit = 2;
            double rightLimit = 3;

            bool entersectionFlag = false;

            for (int i = 0; i < points.Count - 1; ++i)
            {
                if (points[i].x > leftLimit && points[i].x < rightLimit && points[i + 1].x > leftLimit && points[i + 1].x < rightLimit)
                {
                    entersectionFlag = true;
                }
            }

            Assert.AreEqual(true, entersectionFlag);
        }

        [TestMethod]
        public void TestMethod4()
        {
            List<doublePoint> points = Astroida.CalcGraph(100, 0.3f);

            double leftLimit = -1;
            double rightLimit = -0.31;

            bool entersectionFlag = false;

            for (int i = 0; i < points.Count - 1; ++i)
            {
                if (points[i].x > leftLimit && points[i].x < rightLimit && points[i + 1].x > leftLimit && points[i + 1].x < rightLimit)
                {
                    entersectionFlag = true;
                }
            }

            Assert.AreEqual(false, entersectionFlag);
        }

        [TestMethod]
        public void TestMethod5()
        {
            List<doublePoint> points = Astroida.CalcGraph(100, 451);

            double leftLimit = -451;
            double rightLimit = 451;

            bool entersectionFlag = false;

            for (int i = 0; i < points.Count - 1; ++i)
            {
                if (points[i].x > leftLimit && points[i].x < rightLimit && points[i + 1].x > leftLimit && points[i + 1].x < rightLimit)
                {
                    entersectionFlag = true;
                }
            }

            Assert.AreEqual(true, entersectionFlag);
        }
    }
}