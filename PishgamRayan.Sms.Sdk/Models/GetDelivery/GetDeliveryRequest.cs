namespace PishgamRayan.Sms.Sdk.Models.GetDelivery;

public class GetDeliveryRequest
{
    /// <summary>
    /// توکن تایید شده
    /// </summary>
    public string Token { get; set; } = null!;
    /// <summary>
    /// شناسه صف یا صندوق
    /// </summary>
    public int MessageId { get; set; }
    /// <summary>
    /// آرایه ای ازرشته های گیرندگان حداکثر 100 عدد 
    /// </summary>
    public List<string> RecipientNumbers { get; set; } = null!;
}