using App.Services;
using NUnit.Framework;

namespace Unit
{
    public class MutableValueProviderTests
    {
        private const string MutatedValue = "Mutated value for unit test";
        private MutableValueProvider _mutableValueProvider;

        [SetUp]
        public void Setup()
        {
            _mutableValueProvider = new MutableValueProvider { Value = MutatedValue };
        }

        [Test]
        public void ValueTest()
        {
            // ARRANGE
            var expected = MutatedValue;

            // ACT
            var actual = _mutableValueProvider.Value;

            // ASSERT
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}