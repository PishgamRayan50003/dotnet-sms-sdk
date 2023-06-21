﻿namespace PishgamRayan.Sms.Sdk.Models.SendVoiceOtp
{
    public class SendVoiceOtpRequest
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
        /// شماره همراه یا ثابت
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// کد دلخواه خود را وارد نمایید
        /// حداقل 4 و حداکثر 8 رقم
        /// </summary>
        public int? OptionalCode { get; set; }
    }
}