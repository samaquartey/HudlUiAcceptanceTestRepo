using HudlApiTest.Helpers;
using HudlApiTest.PostObjects;
using HudlApiTest.ResponseObjects;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Net;
using TechTalk.SpecFlow;

namespace HudlApiTest.Steps
{
    [Binding]
    public class ApiPutSteps : BaseApi
    {
        public NewOpponentPostObject NewOpponentPostObject { get; set; }

        public ApiPutSteps(NewOpponentPostObject newOpponentPostObject)
        {
            NewOpponentPostObject = newOpponentPostObject;
        }


        [Then(@"opponent data in response has new game Id ""(.*)""")]
        public void ThenOpponentDataInResponseHasNewGameId(int gameId)
        {
            Assert.IsTrue(Response.StatusCode == HttpStatusCode.OK, "api post failed");
            Assert.IsTrue(Response.IsSuccessful == true, "api post was not successful");

            var deserializeObject = JsonConvert.DeserializeObject<OpponentInformation>(Response.Content);

            Assert.AreEqual(NewOpponentPostObject.gameId, gameId, "game ids should be same");
            Assert.AreEqual(NewOpponentPostObject.gameType, deserializeObject.gameType, "game type should be same");
            Assert.AreEqual(NewOpponentPostObject.isHome, deserializeObject.IsHome, "is home should be same");
            Assert.AreEqual(NewOpponentPostObject.sqlId, deserializeObject.sqlId, "sqlId should be same");
        }

    }
}
