using System;
using System.Collections;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace TestFlow
{
    [Binding]
    public class SpecFlowFeatureSteps
    {
        Calculator _calculator; //= new Calculator();

        public SpecFlowFeatureSteps(Calculator calculator)
        {
            _calculator = calculator;
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int value)
        {
            _calculator.SetInput(value);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _calculator.Add();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int value)
        {
            int result = _calculator.GetResult();
            Assert.AreEqual(value, result);
        }
    }
}
