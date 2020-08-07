using Maria;
using NUnit.Framework;

namespace Maria.Tests.Core
{
    [TestFixture]
    public class Tests
    {
        [TestCase]
        public void TestClamp()
        {
            Assert.That(Algorithms.clamp(2, 0, 1), Is.EqualTo(1));
            Assert.That(Algorithms.clamp(-2, 0, 1), Is.EqualTo(0));
            Assert.That(Algorithms.clamp(2, 10, 10), Is.EqualTo(10));
            Assert.That(Algorithms.clamp(5, -20, -5), Is.EqualTo(-5));
            Assert.That(Algorithms.clamp(int.MaxValue, int.MinValue, int.MinValue), Is.EqualTo(int.MinValue));
        }
    }
}