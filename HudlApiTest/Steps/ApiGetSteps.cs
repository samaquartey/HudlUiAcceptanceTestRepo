using HudlApiTest.ApiActions;
using HudlApiTest.Helpers;
using HudlApiTest.ResponseObjects;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.Collections.Generic;
using System.Net;
using TechTalk.SpecFlow;

namespace HudlApiTest.Steps
{
    [Binding]
    public class ApiGetSteps : GetOpponentInformation
    {
        [Given(@"I get list of opponent information for ""(.*)""")]
        public void GivenIGetListOfOpponentInformationFor(string opponent)
        {
            var cookies = new Dictionary<string, string>
            {
                {"username","password" }
            };

            GetOpponentInformationWithDetails(Configs.GetOpponentInfomationApi + "/" + opponent, cookies);
        }

        [Then(@"opponent data in response has opponent Id ""(.*)""")]
        public void ThenOpponentDataInResponseHasOpponentId(string opponentId)
        {
            Assert.IsTrue(Response.StatusCode == HttpStatusCode.OK, "api status code was not 200");

            var deserializedResponseContent = JsonConvert.DeserializeObject<List<OpponentInformation>>(Response.Content);

            foreach (var item in deserializedResponseContent)
            {
                Assert.IsTrue(item.opponentId == opponentId, "gameType is wrong");
                Assert.IsTrue(item.opponentId == "", "opponent name is wrong");
                Assert.IsTrue(item.IsHome == true, "is home is wrong");
                Assert.IsTrue(item.gameType == 0, "gameType is wrong");
            }
        }


        [Then(@"api get call failed with error")]
        public void ThenApiGetCallFailedWithError()
        {
            Assert.IsFalse(Response.IsSuccessful, "api request should fail but was successful");
            Assert.IsTrue(Response.ResponseStatus == ResponseStatus.Error, "api request should error");
        }
    }
}
