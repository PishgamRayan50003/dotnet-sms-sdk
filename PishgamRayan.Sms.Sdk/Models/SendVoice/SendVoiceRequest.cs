namespace PishgamRayan.Sms.Sdk.Models.SendVoice
{
    public class SendVoiceRequest
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
        /// لیست شماره ها
        /// </summary>
        public string[] RecipientNumbers { get; set; }
        /// <summary>
        /// شناسه صوت داخل پنل پیامک
        /// </summary>
        public int VoiceId { get; set; }
        /// <summary>
        /// حداکثر تلاش برای هر شماره
        /// چند بار پیام ارسال شود در صورت موفق نبودن
        /// </summary>
        public int MaxTryCount { get; set; }
        /// <summary>
        /// مدت تاخیر بین تلاش ها بر اساس دقیقه
        /// چند دقیقه یکبار تماس بگیرد؟
        /// </summary>
        public int MinuteBetweenTries { get; set; }
    }
}