namespace PishgamRayan.Sms.Sdk.Models.GetMessage
{
    public class GetMessageRequest
    {
        /// <summary>
        /// توکن تایید شده
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// از تاریخ به صورت شمسی مثال
        /// 1401/10/15
        /// </summary>
        public string DateTimeFrom { get; set; }
        /// <summary>
        /// تا تاریخ به صورت شمسی مثال
        /// 1401/10/20
        /// </summary>
        public string DateTimeTo { get; set; }
        public string PrivateNumber { get; set; }
        /// <summary>
        /// IsRead
        /// به این مقدار به روز رسانی می شود
        /// در صورت ترو شدن مجددا پیام بازخوانی نمی شود
        /// </summary>
        public bool MarkAsRead { get; set; }
    }
}