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
        /// شناسه صدای آپلود شده در پنل پیامک
        /// </summary>
        public int VoiceId { get; set; }
        /// <summary>
        /// کد خطاهای آپلود فایل صوتی جدید
        /// </summary>
        public VoiceUploadErrors? UploadVoiceErrors { get; set; }
    }
}