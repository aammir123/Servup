using API.Helper;
using API.Models.UserManagement;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace API.Controllers.UserManagement
{
    /// <summary>
    /// 
    /// </summary>
    public class SPRegistrationController : ApiController
    {

        
        [Route("ServUpApi/v1/SpRegisteration/SpRegisterAPI")]
        [HttpGet]
        public async Task<IHttpActionResult> SPRegisterAPI()
        {
            var IndustryTypeObject = GlobalMethod.GetIndustryTypeLovs();            
            return (IHttpActionResult)new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.OK, ReasonPhrase = "Industry type lovs will be sent" };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns
        /// 

        [Route("ServUpApi/v1/SpRegisteration/SaveSPPersonelInfoAPI")]
        [HttpPost]
        public HttpResponseMessage SaveSPPersonelInfoAPI(UserPersonelInfo Obj)
        {
            var ServiceTypeLovsObject = GlobalMethod.GetServiceTypeLovs();
            return new HttpResponseMessage() { ReasonPhrase = "New SP has been logged in this phase and service types drop down and SP id has been sent for 2nd step" };
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 

        [Route("ServUp/Api/v1/SpRegisteration/SaveSPProductInfoAPI")]
        [HttpPost]
        public HttpResponseMessage SaveSPProductInfoAPI(int SPId, [FromBody]string ServiceDescObject)
        {
            //Service ServiceObject = new Service(); //save ServiceDescObject

            int defaultID = 1;    // get the current default terms and conditions.
            var TermsANDConditionsObject = GlobalMethod.TermsANDConditions(defaultID);
            return new HttpResponseMessage() { ReasonPhrase = "SP's product info has been logged in this phase and terms and conditions has been sent for 3rd step" };
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 

        [Route("ServUpApi/v1/SpRegisteration/CreateSPAPI")]
        [HttpPost]
        public HttpResponseMessage CreateSPAPI(string email)
        {

            SendWelcomeEmail(email);
            return new HttpResponseMessage() { ReasonPhrase = "SP has been created " };
        }


        [Route("ServUpApi/v1/SpRegisteration/SendActivationEmail")]
        [HttpPost]
        private void SendWelcomeEmail(string email)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        /// 

        [Route("ServUpApi/v1/SpRegisteration/SaveSPProductInfoAPI")]
        [HttpPost]
        public HttpResponseMessage SendTermsANDConditionsEmailAPI(string email)
        {
            return new HttpResponseMessage() { ReasonPhrase = "Terms and Conditions has been sent to personel email of SP" };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
    }
}
