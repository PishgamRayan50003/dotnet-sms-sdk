using PishgamRayan.Sms.Sdk;

namespace PishgamRayan.Sms.Sdk.Models.GetCredit
{
    public class GetCreditResponse
    {
        /// <summary>
        /// کد وضعیت
        /// </summary>
        public ApiStatusCode StatusCode { get; set; }
        /// <summary>
        /// اعتبار
        /// </summary>
        public long Credit { get; set; }
    }
}