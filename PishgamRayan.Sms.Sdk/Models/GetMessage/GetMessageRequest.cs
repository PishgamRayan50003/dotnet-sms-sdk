namespace PishgamRayan.Sms.Sdk.Models.GetMessage;

public class GetMessageRequest
{
    /// <summary>
    /// توکن تایید شده
    /// </summary>
    public string Token { get; set; } = null!;
    /// <summary>
    /// از تاریخ به صورت شمسی مثال
    /// 1401/10/15
    /// </summary>
    public string DateTimeFrom { get; set; } = null!;
    /// <summary>
    /// تا تاریخ به صورت شمسی مثال
    /// 1401/10/20
    /// </summary>
    public string DateTimeTo { get; set; } = null!;
    public string PrivateNumber { get; set; } = null!;
    /// <summary>
    /// IsRead
    /// به این مقدار به روز رسانی می شود
    /// در صورت ترو شدن مجددا پیام بازخوانی نمی شود
    /// </summary>
    public bool MarkAsRead { get; set; }
}