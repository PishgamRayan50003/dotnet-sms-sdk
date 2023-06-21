using PishgamRayan.Sms.Sdk;

namespace PishgamRayan.Sms.Sdk.Models.SendSms
{
    public class SendSmsResponse
    {
        /// <summary>
        /// شناسه صف یا صندوق
        /// </summary>
        public int MessageId { get; set; }
        /// <summary>
        /// وضعیت ارسال
        /// </summary>
        public ApiStatusCode StatusCode { get; set; }
        /// <summary>
        /// تعداد بلک لیست
        /// </summary>
        public int BlackListCount { get; set; }
    }
}