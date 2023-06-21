﻿namespace PishgamRayan.Sms.Sdk.Models.GetVoiceStatus
{
    public class GetVoiceStatusRequest
    {
        /// <summary>
        /// توکن تایید شده
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// شماره فرستنده
        /// </summary>
        public string SenderNumber { get; set; }
        /// <summary>
        /// شناسه صوت
        /// </summary>
        public int MessageId { get; set; }
    }
}