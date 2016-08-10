using API.Models.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace API.Controllers.UserManagement
{
    public class UserRegisterationController : ApiController
    {



        /// <summary>
        /// Gets customer interests.
        /// </summary>
        /// <param name="profileInterests">ProfileInterests Model</param>
        /// <remarks>Customer Interests</remarks>
        /// <response code="200">Success</response>
        /// <response code="206">Partialcontent</response>
        /// /// <response code="409">Conflict</response>
        /// /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        [Route("ServUpApi/v1/UserRegisteration/Register")]
        [HttpPost]
        //[ResponseType(typeof(HttpResponseMessage))]
        public async Task<IHttpActionResult> UserRegisterAPI(UserRegisterationInfo obj)
        {   
            return  (IHttpActionResult)new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.OK, ReasonPhrase = "Verification SMS PIN has been sent" };
        }


        /*
        public async Task<IHttpActionResult> ValidateSMSPinAPI(string MSISDN, string PIN)
        {
            return (IHttpActionResult)new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.OK, ReasonPhrase = "Verification SMS PIN has been sent" };
        }

        public async Task<IHttpActionResult> ResendSMSPinAPI(string MSISDN)
        {
            return (IHttpActionResult)new HttpResponseMessage() { ReasonPhrase = "Verification SMS PIN has been sent" };
        }

        public async Task<IHttpActionResult> CreateAppUserAPI(string MSISDN, string Password)
        {
            return (IHttpActionResult)new HttpResponseMessage() { ReasonPhrase = "AppUser Created" };
        }*/
    }
}
