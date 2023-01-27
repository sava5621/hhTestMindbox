namespace hhTestMindboxTesting
{
    public class TestsTriangle
    {
        Context _context;
        [SetUp]
        public void Setup()
        {
            _context = new Context();
        }

        [TestCase(13, 14, 15, 84)]
        [TestCase(26, 28, 30, 336)]
        public void ItWorks(double firstSide, double secondSide, double thirdSide, double expected)
        {
            _context.SetStrategy(new Triangle(firstSide, secondSide, thirdSide));
            var actual = _context.GetSquare();
            Assert.That( actual, Is.EqualTo(expected));
        }
        [TestCase(1, 14, 15)]
        [TestCase(-12, 14, 15)]
        public void ExceptionSquare(double firstSide, double secondSide, double thirdSide)
        {
            _context.SetStrategy(new Triangle(firstSide, secondSide, thirdSide));
            Assert.That(() =>_context.GetSquare(), Throws.Exception);
        }
        [TestCase(3, 4, 5, "прямоугольный треугольник")]
        [TestCase(26, 28, 30, "треугольник")]
        public void IsRectangular(double firstSide, double secondSide, double thirdSide, string expected)
        {
            _context.SetStrategy(new Triangle(firstSide, secondSide, thirdSide));
            var actual = _context.GetInfo();
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}