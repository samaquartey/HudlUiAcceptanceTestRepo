using RestSharp;
using System.Collections.Generic;

namespace HudlApiTest.Helpers
{
    public class BaseApi
    {
        public IRestResponse Response { get; set; }
        public RestClient RestClient { get; set; }
        public RestRequest RestRequest { get; set; }

        //RestClient Method
        public RestClient GoToRestClient(string api)
        {
            return RestClient = new RestClient(api)
            {
                Timeout = -1
            };
        }


        //Api Get request
        public void ApiGetRequest(string api,Dictionary<string,string> cookies)
        {
            RestClient = GoToRestClient(api);
            RestRequest = new RestRequest(Method.GET);
            Response = RestClient.Execute(RestRequest);
            foreach(var cookie in cookies)
            {
                RestRequest.AddCookie(cookie.Key, cookie.Value);
            }
        }


        //Api post request with headers or no headers
        public void ApiPostRequestWithHeaders(string api, string postBody, Dictionary<string,string> headers = null)
        {
            RestClient = GoToRestClient(api);
            RestRequest = new RestRequest(Method.POST);

            if(headers != null)
            {
                foreach(var header in headers)
                {
                    RestRequest.AddHeader(header.Key, header.Value);
                }
            }

            RestRequest.AddJsonBody(postBody);
            Response = RestClient.Execute(RestRequest);
        }


        //Api post request with cookies or no cookies
        public void ApiPostRequestWithCookies(string api, string postBody, Dictionary<string, string> cookies)
        {
            RestClient = GoToRestClient(api);
            RestRequest = new RestRequest(Method.POST);

            if (cookies != null)
            {
                foreach (var cookie in cookies)
                {
                    RestRequest.AddCookie(cookie.Key, cookie.Value);
                }
            }

            RestRequest.AddJsonBody(postBody);
            Response = RestClient.Execute(RestRequest);
        }


        //Api put resquest with headers or no headers
        public void ApiPutRequest(string api, string putBody, Dictionary<string, string> headers = null)
        {
            RestClient = GoToRestClient(api);
            RestRequest = new RestRequest(Method.PUT);

            if (headers != null)
            {
                foreach (var cookie in headers)
                {
                    RestRequest.AddCookie(cookie.Key, cookie.Value);
                }
            }

            RestRequest.AddJsonBody(putBody);
            Response = RestClient.Execute(RestRequest);
        }


        //Api delete request
        public void ApiDeleteRequest(string api, string idToDelete, Dictionary<string, string> headers = null)
        {
            RestClient = GoToRestClient(api + "/" + idToDelete);
            RestRequest = new RestRequest(Method.DELETE);

            if (headers != null)
            {
                foreach (var cookie in headers)
                {
                    RestRequest.AddCookie(cookie.Key, cookie.Value);
                }
            }

            Response = RestClient.Execute(RestRequest);
        }
    }
}
