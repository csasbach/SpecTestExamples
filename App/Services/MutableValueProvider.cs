namespace App.Services
{
    public class MutableValueProvider : IProvideValue
    {
        public string Value { get; set; } = "I provide a mutable value.";
    }
}
