using App.Services;
using NUnit.Framework;
using Spec.Factories;
using Spec.Objects.ServiceObjects;
using TechTalk.SpecFlow;

namespace Spec.Steps
{
    [Binding]
    public class ValueProviderServiceSteps
    {
        private readonly ScenarioContext _scenarioContext;

        private IProvideValue _valueProvider;
        private IProvideValue ValueProvider => _valueProvider ??= _scenarioContext.ScenarioContainer.Resolve<ValueProviderServiceFactory>().Current;

        private ValueProviderService _valueProviderService;
        private ValueProviderService ValueProviderService => _valueProviderService ??= ValueProviderService.Initialize(ValueProvider);
        private string Value
        {
            set => _scenarioContext["Value"] = value;
            get
            {
                if (_scenarioContext.TryGetValue("Value", out var response) && response is string value)
                {
                    return value;
                }

                Assert.Fail("Could not find 'Value' in the scenario context.");
                return null;
            }
        }

        public ValueProviderServiceSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"I access the value property of the value provider")]
        public void WhenIAccessTheValuePropertyOfTheValueProvider()
        {
            Value = ValueProviderService.Value();
        }
        
        [Then(@"I am returned a value")]
        public void ThenIAmReturnedAValue()
        {
            Assert.IsNotEmpty(Value);
        }
    }
}
