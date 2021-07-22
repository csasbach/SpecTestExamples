using App.Services;
using NUnit.Framework;

namespace Unit
{
    public class StaticValueProviderTests
    {
        private const string StaticValue = "I provide a static value.";
        private StaticValueProvider _staticValueProvider;

        [SetUp]
        public void Setup()
        {
            _staticValueProvider = new StaticValueProvider();
        }

        [Test]
        public void ValueTest()
        {
            // ARRANGE
            var expected = StaticValue;

            // ACT
            var actual = _staticValueProvider.Value;

            // ASSERT
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}