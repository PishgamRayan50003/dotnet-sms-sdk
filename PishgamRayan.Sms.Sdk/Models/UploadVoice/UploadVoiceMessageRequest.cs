namespace PishgamRayan.Sms.Sdk.Models.UploadVoice
{
    public class UploadVoiceMessageRequest
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
        /// عنوان
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// فایل به صورت بایت
        /// </summary>
        public byte[] File { get; set; }
        /// <summary>
        /// آیا ماندگار باشد؟
        /// </summary>
        public bool IsPersist { get; set; } = false;
    }
}