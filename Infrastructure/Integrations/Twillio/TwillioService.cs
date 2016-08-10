using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Infrastructure.Integrations.Twillio.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Infrastructure.Integrations.Twillio
{
    public class TwillioService
    {
        public string GetOperator(string mobileNumber)
        {
            //do call operator lookup service here

            const string accountSid = "AC44740f9c7a435a4453196a7c7885303f";
            const string authToken = "02e8028a7c5f6ee16d14babe22ed37ab";
            var client = new RestClient("https://lookups.twilio.com") { Authenticator = new HttpBasicAuthenticator(accountSid, authToken) };
            var request = new RestRequest("/v1/PhoneNumbers/" + mobileNumber.Substring(2) , Method.GET);


            request.AddParameter("Type", "carrier");



            var response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<OperatorLookupResponse>(response.Content).carrier.name;
            }

            return "NotFound";
        }

        public string SendSMS(string mobileNumber,string SMS)
        {
            const string accountSid = "AC44740f9c7a435a4453196a7c7885303f";
            const string authToken = "02e8028a7c5f6ee16d14babe22ed37ab";
            var client = new RestClient("https://api.twilio.com/2010-04-01") { Authenticator = new HttpBasicAuthenticator(accountSid, authToken) };
            var request = new RestRequest("Accounts/" + accountSid + "/Messages.json", Method.POST);

            request.AddParameter("To", "+" + mobileNumber.Substring(2));
            request.AddParameter("From", "Servup");
            

            request.AddParameter("Body", SMS);



            var response = client.Execute(request);

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(response.Content);



            JObject o = JObject.Parse(response.Content);

            //This will be "Apple"
            //string name = (string)o["body"];


            if (response.StatusCode == HttpStatusCode.OK)
            {
                return "OK";

            }

            return "KO";

        }
    }
}
