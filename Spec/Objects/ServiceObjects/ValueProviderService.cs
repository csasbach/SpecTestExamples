using App.Services;

namespace Spec.Objects.ServiceObjects
{
    internal class ValueProviderService
    {
        private readonly IProvideValue _valueProvider;

        private static ValueProviderService _instance;
        public static ValueProviderService Initialize(IProvideValue httpClient)
        {
            return _instance ??= new ValueProviderService(httpClient);
        }

        private ValueProviderService(IProvideValue valueProvider) {           
            _valueProvider = valueProvider;
        }

        public string Value()
        {
            return _valueProvider.Value;
        }
    }
}
