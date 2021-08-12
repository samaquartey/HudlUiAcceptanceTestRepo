using HudlApiTest.Helpers;
using System.Collections.Generic;

namespace HudlApiTest.ApiActions
{
    public class CreateOpponentInformation : BaseApi
    {
        public void CreateNewOpponentInformation(string api, string body, Dictionary<string,string> cookies)
        {
            ApiPostRequestWithCookies(api,body,cookies);
        }
    }
}
