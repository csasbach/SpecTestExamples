namespace App.Services
{
    public class InjectedValueProvider : IProvideValue
    {
        public string Value { get; }

        public InjectedValueProvider(string theValue)
        {
            Value = theValue;
        }
    }
}