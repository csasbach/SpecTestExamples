using App.Services;
using System;

namespace Spec.Factories
{
    class ValueProviderServiceFactory
    {
        private readonly Lazy<IProvideValue> _currentValueProviderLazy;

        public ValueProviderServiceFactory()
        {
            _currentValueProviderLazy = new Lazy<IProvideValue>(CreateValueProvider);
        }

        public IProvideValue Current => _currentValueProviderLazy.Value;
        
        private static IProvideValue CreateValueProvider()
        {
            var valueProvider = new StaticValueProvider();
            //var valueProvider = new InjectedValueProvider("I provide an injected value");
            //var valueProvider = new MutableValueProvider { Value = "I am providing a value that has been mutated." };

            return valueProvider;
        }
    }
}
