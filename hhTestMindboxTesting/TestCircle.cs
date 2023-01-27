using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhTestMindboxTesting
{
    public class TestCircle
    {
        Context _context;
        [SetUp]
        public void Setup()
        {
            _context = new Context();
        }
        [TestCase(13, 169)]
        [TestCase(26, 676)]
        public void ItWorks(double radius, double expected)
        {
            _context.SetStrategy(new Circle(radius));
            var actual = _context.GetSquare();
            Assert.That(actual, Is.EqualTo(expected* Math.PI));
        }
        [TestCase(0)]
        [TestCase(int.MinValue)]
        public void ExceptionSquare(double radius)
        {
            _context.SetStrategy(new Circle(radius));
            Assert.That(() => _context.GetSquare(), Throws.Exception);
        }
        
        [TestCase(1, "круг")]
        public void IsRectangular(double radius, string expected)
        {
            _context.SetStrategy(new Circle(radius));
            var actual = _context.GetInfo();
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
