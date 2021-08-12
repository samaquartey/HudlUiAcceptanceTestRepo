using HudlApiTest.ApiActions;
using HudlApiTest.Helpers;
using HudlApiTest.PostObjects;
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
    public class ApiPostSteps : CreateOpponentInformation
    {
        public NewOpponentPostObject NewOpponentPostObject { get; set; }

        public ApiPostSteps(NewOpponentPostObject newOpponentPostObject)
        {
            NewOpponentPostObject = newOpponentPostObject;
        }

        [Given(@"create opponent information with table details")]
        public void GivenCreateOpponentInformationWithTableDetails(Table table)
        {
            var cookies = new Dictionary<string, string>
            {
                {"username","password" }
            };

            var serializedObject = JsonConvert.SerializeObject(new NewOpponentPostObject(table));
            CreateNewOpponentInformation(Configs.PostOpponentInfomationApi,serializedObject,cookies);
        }

        [Then(@"opponent data is created successfully")]
        public void ThenOpponentDataIsCreatedSuccessfully()
        {
            Assert.IsTrue(Response.StatusCode == HttpStatusCode.OK,"api post failed");
            Assert.IsTrue(Response.IsSuccessful == true, "api post was not successful");

            var deserializeObject = JsonConvert.DeserializeObject<OpponentInformation>(Response.Content);

            Assert.AreEqual(NewOpponentPostObject.gameId,deserializeObject.gameId, "game ids should be same");
            Assert.AreEqual(NewOpponentPostObject.gameType, deserializeObject.gameType, "game type should be same");
            Assert.AreEqual(NewOpponentPostObject.isHome, deserializeObject.IsHome, "is home should be same");
            Assert.AreEqual(NewOpponentPostObject.sqlId, deserializeObject.sqlId, "sqlId should be same");
        }


        [Then(@"api post to create opponent information should error")]
        public void ThenApiPostToCreateOpponentInformationShouldError()
        {
            Assert.IsFalse(Response.IsSuccessful, "api request should fail but was successful");
            Assert.IsTrue(Response.ResponseStatus == ResponseStatus.Error, "api request should error");
        }
    }
}
