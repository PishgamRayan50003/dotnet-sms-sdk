namespace PishgamRayan.Sms.Sdk.Models.SendVoice;

public class SendVoiceResponse
{
    /// <summary>
    /// شناسه صف یا صندوق
    /// </summary>
    public int MessageId { get; set; }
    public ApiStatusCode StatusCode { get; set; }
}