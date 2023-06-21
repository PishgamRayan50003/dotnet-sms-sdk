using System.Text.Json;
using PishgamRayan.Sms.Sdk;
using PishgamRayan.Sms.Sdk.Models.GetCredit;
using PishgamRayan.Sms.Sdk.Models.GetDelivery;
using PishgamRayan.Sms.Sdk.Models.GetMessage;
using PishgamRayan.Sms.Sdk.Models.GetVoiceStatus;
using PishgamRayan.Sms.Sdk.Models.SendOtp;
using PishgamRayan.Sms.Sdk.Models.SendSms;
using PishgamRayan.Sms.Sdk.Models.SendVoice;
using PishgamRayan.Sms.Sdk.Models.SendVoiceOtp;
using PishgamRayan.Sms.Sdk.Models.UploadVoice;

//توکن تایید شده
const string token = "token";

//ارسال پیامک
Console.WriteLine("Sending sms, please wait ....");
SendSmsResponse sendSmsResponse = await Pishgam.SendSms(new SendSmsRequest
{
    Token = token,
    MessageBodies = new[] { "تست ارسال با وب سرویس" },
    RecipientNumbers = new[] { "9131234567", "09391234567" },
    SenderNumber = "5000"
});
Console.WriteLine($"Sending sms response is : {JsonSerializer.Serialize(sendSmsResponse)}");
Console.WriteLine("Press enter to go next api....");
Console.ReadLine();

//نمایش اعتبار
Console.WriteLine("Get Credit, please wait ....");
GetCreditResponse getCreditResponse = await Pishgam.GetCredit(new GetCreditRequest
{
    Token = token
});
Console.WriteLine($"Get Credit response is : {JsonSerializer.Serialize(getCreditResponse)}");
Console.WriteLine("Press enter to go next api....");
Console.ReadLine();

//دریافت وضعیت دلیوری
Console.WriteLine("Get delivery, please wait ....");
GetDeliveryResponse getDeliveryResponse = await Pishgam.GetDelivery(new GetDeliveryRequest
{
    Token = token,
    MessageId = 6416,
    RecipientNumbers = new List<string> { "9131234567", "09391234567" }
});
Console.WriteLine($"Get delivery response is : {JsonSerializer.Serialize(getDeliveryResponse)}");
Console.WriteLine("Press enter to go next api....");
Console.ReadLine();

//دریافت پیام
Console.WriteLine("Get message, please wait ....");
GetMessageResponse getMessageResponse = await Pishgam.GetMessage(new GetMessageRequest
{
    Token = token,
    DateTimeFrom = "1402/01/14 09:00:00",
    DateTimeTo = "1402/01/14 13:28:05",
    MarkAsRead = false,
    PrivateNumber = "5000"
});
Console.WriteLine($"Get message response is : {JsonSerializer.Serialize(getMessageResponse)}");
Console.WriteLine("Press enter to go next api....");
Console.ReadLine();

//ارسال رمز یکبار مصرف صوتی
Console.WriteLine("Sending voice otp, please wait ....");
SendVoiceOtpResponse sendVoiceOtpResponse = await Pishgam.SendVoiceOtp(new SendVoiceOtpRequest
{
    Token = token,
    SenderNumber = "913000000",
    Number = "09131234567",
    OptionalCode = 1223
});
Console.WriteLine($"Sending voice otp response is : {JsonSerializer.Serialize(sendVoiceOtpResponse)}");
Console.WriteLine("Press enter to go next api....");
Console.ReadLine();

#if net7
//آپلود فایل صوتی جدید
Console.WriteLine("Uploading voice message, please wait ....");
var bytes = await File.ReadAllBytesAsync("C:\\Voice.mp3");
UploadVoiceMessageResponse uploadVoiceMessageResponse = await Pishgam.UploadVoiceMessage(new UploadVoiceMessageRequest
{
    Token = token,
    SenderNumber = "913000000",
    Title = "آپلود صوت جدید با وب سرویس",
    File = bytes,
    IsPersist = true,
    CallFromCellPhone = ""
});
Console.WriteLine($"Uploading voice message response is : {JsonSerializer.Serialize(uploadVoiceMessageResponse)}");
Console.WriteLine("Press enter to go next api....");
Console.ReadLine();

#endif
//بررسی وضعیت فایل آپلود شده
Console.WriteLine("Get voice status, please wait ....");
GetVoiceStatusResponse getVoiceStatusResponse = await Pishgam.GetVoiceStatus(new GetVoiceStatusRequest
{
    Token = token,
    SenderNumber = "913000000",
    MessageId = 12345678
});
Console.WriteLine($"Get voice status response is : {JsonSerializer.Serialize(getVoiceStatusResponse)}");
Console.WriteLine("Press enter to go next api....");
Console.ReadLine();

//ارسال پیامک صوتی
Console.WriteLine("Sending voice message, please wait ....");
SendVoiceResponse sendVoiceResponse = await Pishgam.SendVoice(new SendVoiceRequest
{
    Token = token,
    SenderNumber = "913000000",
    RecipientNumbers = new[] { "09131234567", "03131234567" },
    VoiceMessageId = 12345678,
    MaxTryCount = 1,
    MinuteBetweenTries = 2
});
Console.WriteLine($"Sending voice message response is : {JsonSerializer.Serialize(sendVoiceResponse)}");
Console.WriteLine("Press enter to go next api....");
Console.ReadLine();

//ارسال پیامک احرازهویت
Console.WriteLine("Sending otp, please wait ....");
SendSmsResponse sendOtpResponse = await Pishgam.SendOtp(new SendOtpRequest
{
    Token = token,
    SenderNumber = "5000",
    RecipientNumbers = new[] { "09131234567", "9391234567" },
    OtpId = 1036,
    Parameters = new object[] { "1245", "احمد" }
});
Console.WriteLine($"Sending otp response is : {JsonSerializer.Serialize(sendOtpResponse)}");
Console.WriteLine("Press enter to go next api....");
Console.ReadLine();