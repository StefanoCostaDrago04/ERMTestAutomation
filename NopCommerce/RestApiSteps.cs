using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NopCommerce.Infrastructure;
using NUnit.Framework;

namespace NopCommerce
{
    [Binding]
    public sealed class RestApiSteps
    {
        RestApiService rest;
        List<RestApiService.ApiItem> items;

       [Given(@"I need to check ""(.*)"" endpoint")]
        public void GivenINeedToCheckEndpoint(string endpoint)
        {
            rest = new RestApiService();          
        }


        [When(@"I make a rest request to the endpoint and fecth the results")]
        public void WhenIMakeARestRequestToTheEndpointAndFecthTheResults()
        {
            items = rest.GetItems();
        }

        [Then(@"the expected results are retrieved")]
        public void ThenTheExpectedResultsAreRetrieved()
        {
            Assert.AreEqual(items.Count, 100);
            foreach(var item in items)
            {
                Assert.IsTrue(item.body != "");
                Assert.IsTrue(item.title != "");
            }
        }
    }
}
