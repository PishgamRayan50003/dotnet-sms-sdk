namespace PishgamRayan.Sms.Sdk.Models.SendVoice;

public class SendVoiceRequest
{
    /// <summary>
    /// توکن تایید شده
    /// </summary>
    public string Token { get; set; } = null!;
    /// <summary>
    /// شماره فرستنده
    /// </summary>
    public string SenderNumber { get; set; } = null!;
    /// <summary>
    /// لیست شماره ها
    /// </summary>
    public string[] RecipientNumbers { get; set; } = null!;
    /// <summary>
    /// شناسه صوت
    /// </summary>
    public int VoiceMessageId { get; set; }
    /// <summary>
    /// چند بار پیام ارسال بشه در صورت موفق نبودن
    /// </summary>
    public int MaxTryCount { get; set; }
    /// <summary>
    /// چند دقیقه زنگ را بزنه
    /// </summary>
    public int MinuteBetweenTries { get; set; }
}