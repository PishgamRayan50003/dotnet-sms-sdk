namespace PishgamRayan.Sms.Sdk.Models.SendSms
{
    public class SendSmsRequest
    {
        /// <summary>
        /// توکن تایید شده
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// شماره فرستنده
        /// </summary>
        public string SenderNumber { get; set; }

        /// <summary>
        /// متن های پیامک، اگر یکی بود به همه شماره ها بده اگر مساوی بود نظیر به نظیر
        /// </summary>
        public string[] MessageBodies { get; set; }

        /// <summary>
        /// لیست شماره ها
        /// </summary>
        public string[] RecipientNumbers { get; set; }
    }
}