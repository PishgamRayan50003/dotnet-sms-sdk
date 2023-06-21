using System;
using System.Collections.Generic;

namespace PishgamRayan.Sms.Sdk.Models.GetMessage
{
    public class GetMessageResponse
    {
        public ApiStatusCode StatusCode { get; set; }
        public List<MessageDto> Messages { get; set; }
    }

    public class MessageDto
    {
        public string PrivateNumber { get; set; }
        public string SenderMobile { get; set; }
        public string SmsText { get; set; }
        public DateTime DateTimeReceive { get; set; }
    }
}