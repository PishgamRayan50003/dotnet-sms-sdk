using PishgamRayan.Sms.Sdk;

namespace PishgamRayan.Sms.Sdk.Models.UploadVoice
{
    public class UploadVoiceMessageResponse
    {
        /// <summary>
        /// وضعیت ارسال
        /// </summary>
        public ApiStatusCode StatusCode { get; set; }
        /// <summary>
        /// شناسه ارسال
        /// </summary>
        public int MessageId { get; set; }
        /// <summary>
        /// کد خطاهای آپلود فایل صوتی جدید
        /// </summary>
        public VoiceUploadErrors? UploadVoiceErrors { get; set; }
    }
}