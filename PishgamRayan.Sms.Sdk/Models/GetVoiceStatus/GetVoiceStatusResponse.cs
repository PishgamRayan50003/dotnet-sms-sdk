using PishgamRayan.Sms.Sdk;

namespace PishgamRayan.Sms.Sdk.Models.GetVoiceStatus
{
    public class GetVoiceStatusResponse
    {
        public ApiStatusCode StatusCode { get; set; }
        public VoiceStatus VoiceStatus { get; set; }
    }
}