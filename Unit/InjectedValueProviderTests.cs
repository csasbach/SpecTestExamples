using App.Services;
using NUnit.Framework;

namespace Unit
{
    public class InjectedValueProviderTests
    {
        private const string InjectedValue = "Injected value for unit test";
        private InjectedValueProvider _injectedValueProvider;

        [SetUp]
        public void Setup()
        {
            _injectedValueProvider = new InjectedValueProvider(InjectedValue);
        }

        [Test]
        public void ValueTest()
        {
            // ARRANGE
            var expected = InjectedValue;

            // ACT
            var actual = _injectedValueProvider.Value;

            // ASSERT
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}