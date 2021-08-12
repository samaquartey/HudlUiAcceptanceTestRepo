using HudlApiTest.Helpers;
using System.Collections.Generic;

namespace HudlApiTest.ApiActions
{
    public class GetOpponentInformation : BaseApi
    {
        public void GetOpponentInformationWithDetails(string api, Dictionary<string, string> cookies)
        {
            ApiGetRequest(api,cookies);
        }
    }
}
