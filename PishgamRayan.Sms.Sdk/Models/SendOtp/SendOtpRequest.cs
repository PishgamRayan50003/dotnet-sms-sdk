namespace PishgamRayan.Sms.Sdk.Models.SendOtp;

public class SendOtpRequest
{
    /// <summary>
    /// توکن تایید شده
    /// </summary>
    public string Token { get; set; } = null!;
    /// <summary>
    /// شناسه قالب پیامک احرازهویت
    /// </summary>
    public int OtpId { get; set; }
    /// <summary>
    /// پارامترهای قالب پیامک احرازهویت
    /// </summary>
    public object[] Parameters { get; set; } = null!;
    /// <summary>
    /// شماره فرستنده
    /// </summary>
    public string SenderNumber { get; set; } = null!;
    /// <summary>
    /// لیست شماره ها
    /// </summary>
    public string[] RecipientNumbers { get; set; } = null!;
}