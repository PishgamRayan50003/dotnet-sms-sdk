namespace PishgamRayan.Sms.Sdk.Models.GetMessage;

public class GetMessageResponse
{
    public ApiStatusCode StatusCode { get; set; }
    public List<MessageDto>? Messages { get; set; }
}

public class MessageDto
{
    public string PrivateNumber { get; set; } = null!;
    public string SenderMobile { get; set; } = null!;
    public string SmsText { get; set; } = null!;
    public DateTime DateTimeReceive { get; set; }
}