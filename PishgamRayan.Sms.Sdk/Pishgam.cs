using System;
using System.Net.Http;
using System.Net.Http.Headers;
#if NET7_0
using System.Net.Http.Json;
#endif
using System.Text.Json;
using System.Threading.Tasks;
using PishgamRayan.Sms.Sdk.Models.GetCredit;
using PishgamRayan.Sms.Sdk.Models.GetDelivery;
using PishgamRayan.Sms.Sdk.Models.GetMessage;
using PishgamRayan.Sms.Sdk.Models.GetVoiceStatus;
using PishgamRayan.Sms.Sdk.Models.SendOtp;
using PishgamRayan.Sms.Sdk.Models.SendSms;
using PishgamRayan.Sms.Sdk.Models.SendVoice;
using PishgamRayan.Sms.Sdk.Models.SendVoiceOtp;
using PishgamRayan.Sms.Sdk.Models.UploadVoice;
using RestSharp;

namespace PishgamRayan.Sms.Sdk
{
    public class Pishgam
    {
        private const string ApiAddress = "http://95.81.81.185:10680/";

        private static readonly JsonSerializerOptions DefaultSerializerSettings =
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        /// <summary>
        /// برای ارسال پیام استفاده می شود
        /// </summary>
        /// <param name="sendSmsRequest"></param>
        /// <returns></returns>
        public static async Task<SendSmsResponse> SendSms(SendSmsRequest sendSmsRequest)
        {
            var client = new RestClient();
            var request = new RestRequest($"{ApiAddress}Messages/Send", Method.Post);
            request.AddHeader("Authorization", sendSmsRequest.Token);
            request.AddHeader("Content-Type", "application/json");
            var body = new SendSmsRequest
            {
                MessageBodies = sendSmsRequest.MessageBodies,
                RecipientNumbers = sendSmsRequest.RecipientNumbers,
                SenderNumber = sendSmsRequest.SenderNumber
            };
            var jsonBody = JsonSerializer.Serialize(body);
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);
            var response = await client.ExecuteAsync(request);
            if (response.Content != null)
                return JsonSerializer.Deserialize<SendSmsResponse>(response.Content, DefaultSerializerSettings) ??
                       new SendSmsResponse { StatusCode = ApiStatusCode.Failed };

            return new SendSmsResponse { StatusCode = ApiStatusCode.Failed };
        }

        /// <summary>
        /// میزان اعتبار کاربر را نمایش می دهد
        /// </summary>
        /// <param name="getCreditRequest"></param>
        /// <returns></returns>
        public static async Task<GetCreditResponse> GetCredit(GetCreditRequest getCreditRequest)
        {
            var client = new RestClient();
            var request = new RestRequest($"{ApiAddress}Messages/GetCredit", Method.Get);
            request.AddHeader("Authorization", getCreditRequest.Token);
            request.AddParameter("text/plain", "", ParameterType.RequestBody);
            var response = await client.ExecuteAsync(request);
            if (response.Content != null)
                return JsonSerializer.Deserialize<GetCreditResponse>(response.Content, DefaultSerializerSettings) ??
                       new GetCreditResponse { StatusCode = ApiStatusCode.Failed };

            return new GetCreditResponse { StatusCode = ApiStatusCode.Failed };
        }

        /// <summary>
        /// این متد در پاسخ  آرایه ای از وضعیت دریافت ها را به ترتیب شماره ها در آرایه ی گیرندگان داده شده نمایش می دهد. 
        /// </summary>
        /// <param name="getDeliveryRequest"></param>
        /// <returns></returns>
        public static async Task<GetDeliveryResponse> GetDelivery(GetDeliveryRequest getDeliveryRequest)
        {
            var client = new RestClient();
            var request = new RestRequest($"{ApiAddress}Messages/GetDelivery", Method.Post);
            request.AddHeader("Authorization", getDeliveryRequest.Token);
            request.AddHeader("Content-Type", "application/json");
            var body = new GetDeliveryRequest
            {
                MessageId = getDeliveryRequest.MessageId,
                RecipientNumbers = getDeliveryRequest.RecipientNumbers
            };
            var jsonBody = JsonSerializer.Serialize(body);
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);
            var response = await client.ExecuteAsync(request);
            if (response.Content != null)
                return JsonSerializer.Deserialize<GetDeliveryResponse>(response.Content, DefaultSerializerSettings) ??
                       new GetDeliveryResponse { StatusCode = ApiStatusCode.Failed };

            return new GetDeliveryResponse { StatusCode = ApiStatusCode.Failed };
        }

        /// <summary>
        /// این متد مربوط به دریافت پیام می باشد و حداکثر 100 پیام بر می گردد و بازه شروع و پایان را باید به صورت شمسی وارد نمایید.
        /// </summary>
        /// <param name="getMessageRequest"></param>
        /// <returns></returns>
        public static async Task<GetMessageResponse> GetMessage(GetMessageRequest getMessageRequest)
        {
            var client = new RestClient();
            var request = new RestRequest($"{ApiAddress}Messages/GetMessage", Method.Post);
            request.AddHeader("Authorization", getMessageRequest.Token);
            request.AddHeader("Content-Type", "application/json");
            var body = new GetMessageRequest
            {
                DateTimeFrom = getMessageRequest.DateTimeFrom,
                DateTimeTo = getMessageRequest.DateTimeTo,
                MarkAsRead = getMessageRequest.MarkAsRead,
                PrivateNumber = getMessageRequest.PrivateNumber
            };
            var jsonBody = JsonSerializer.Serialize(body);
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);
            var response = await client.ExecuteAsync(request);
            if (response.Content != null)
                return JsonSerializer.Deserialize<GetMessageResponse>(response.Content, DefaultSerializerSettings) ??
                       new GetMessageResponse { StatusCode = ApiStatusCode.Failed };

            return new GetMessageResponse { StatusCode = ApiStatusCode.Failed };
        }

        /// <summary>
        /// از طریق این متد می توانید پیام صوتی با رمز یکبار مصرف را به صورت فوری به شماره(های) انتخابی خود ارسال نمایید
        /// و با شماره وارد شده تماس گرفته میشود و رمز یکبار مصرف را به شما اعلام میکند .
        /// اگر کد دلخواه  وارد شود کد کد دلخواه  خوانده می شود.
        /// ولی اگر کد دلخواه وارد نشود کد 5 رقمی تولید شده خوانده می شود .
        /// </summary>
        /// <param name="sendVoiceOtpRequest"></param>
        /// <returns></returns>
        public static async Task<SendVoiceOtpResponse> SendVoiceOtp(SendVoiceOtpRequest sendVoiceOtpRequest)
        {
            var client = new RestClient();
            var request = new RestRequest($"{ApiAddress}Messages/SendVoiceOtp", Method.Post);
            request.AddHeader("Authorization", sendVoiceOtpRequest.Token);
            request.AddHeader("Content-Type", "application/json");
            var body = new SendVoiceOtpRequest
            {
                SenderNumber = sendVoiceOtpRequest.SenderNumber,
                Number = sendVoiceOtpRequest.Number,
                OptionalCode = sendVoiceOtpRequest.OptionalCode
            };
            var jsonBody = JsonSerializer.Serialize(body);
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);
            var response = await client.ExecuteAsync(request);
            if (response.Content != null)
                return JsonSerializer.Deserialize<SendVoiceOtpResponse>(response.Content, DefaultSerializerSettings) ??
                       new SendVoiceOtpResponse { StatusCode = ApiStatusCode.Failed };

            return new SendVoiceOtpResponse { StatusCode = ApiStatusCode.Failed };
        }
#if NET7_0
        /// <summary>
        /// میتوان به صورت byte صدای جدید آپلود کرد
        /// </summary>
        /// <param name="uploadVoiceMessageRequest"></param>
        /// <returns></returns>
        public static async Task<UploadVoiceMessageResponse> UploadVoiceMessage(
            UploadVoiceMessageRequest uploadVoiceMessageRequest)
        {
            try
            {
                var client = new HttpClient
                {
                    BaseAddress = new Uri(ApiAddress)
                };
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", uploadVoiceMessageRequest.Token);

                var uploadVoiceMessage = new UploadVoiceMessageRequest
                {
                    SenderNumber = uploadVoiceMessageRequest.SenderNumber,
                    Title = uploadVoiceMessageRequest.Title,
                    File = uploadVoiceMessageRequest.File,
                    IsPersist = uploadVoiceMessageRequest.IsPersist,
                    CallFromCellPhone = uploadVoiceMessageRequest.CallFromCellPhone
                };

                var response = await client.PostAsJsonAsync("Messages/UploadVoiceMessage", uploadVoiceMessage);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<UploadVoiceMessageResponse>() ??
                       new UploadVoiceMessageResponse { StatusCode = ApiStatusCode.Failed };

            }
            catch
            {
                return new UploadVoiceMessageResponse { StatusCode = ApiStatusCode.Failed };
            }

        }
#endif
        /// <summary>
        /// بررسی وضعیت فایل آپلود شده
        /// </summary>
        /// <param name="voiceStatusRequest"></param>
        /// <returns></returns>
        public static async Task<GetVoiceStatusResponse> GetVoiceStatus(GetVoiceStatusRequest voiceStatusRequest)
        {
            var client = new RestClient();
            var request = new RestRequest($"{ApiAddress}Messages/GetVoiceStatus", Method.Post);
            request.AddHeader("Authorization", voiceStatusRequest.Token);
            request.AddHeader("Content-Type", "application/json");
            var body = new GetVoiceStatusRequest
            {
                SenderNumber = voiceStatusRequest.SenderNumber,
                MessageId = voiceStatusRequest.MessageId
            };
            var jsonBody = JsonSerializer.Serialize(body);
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);
            var response = await client.ExecuteAsync(request);
            if (response.Content != null)
                return JsonSerializer.Deserialize<GetVoiceStatusResponse>(response.Content,
                           DefaultSerializerSettings) ??
                       new GetVoiceStatusResponse { StatusCode = ApiStatusCode.Failed };

            return new GetVoiceStatusResponse { StatusCode = ApiStatusCode.Failed };
        }

        /// <summary>
        /// ارسال پیامک صوتی
        /// </summary>
        /// <param name="sendVoiceRequest"></param>
        /// <returns></returns>
        public static async Task<SendVoiceResponse> SendVoice(SendVoiceRequest sendVoiceRequest)
        {
            var client = new RestClient();
            var request = new RestRequest($"{ApiAddress}Messages/SendVoice", Method.Post);
            request.AddHeader("Authorization", sendVoiceRequest.Token);
            request.AddHeader("Content-Type", "application/json");
            var body = new SendVoiceRequest
            {
                SenderNumber = sendVoiceRequest.SenderNumber,
                RecipientNumbers = sendVoiceRequest.RecipientNumbers,
                VoiceMessageId = sendVoiceRequest.VoiceMessageId,
                MaxTryCount = sendVoiceRequest.MaxTryCount,
                MinuteBetweenTries = sendVoiceRequest.MinuteBetweenTries
            };
            var jsonBody = JsonSerializer.Serialize(body);
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);
            var response = await client.ExecuteAsync(request);
            if (response.Content != null)
                return JsonSerializer.Deserialize<SendVoiceResponse>(response.Content, DefaultSerializerSettings) ??
                       new SendVoiceResponse { StatusCode = ApiStatusCode.Failed };

            return new SendVoiceResponse { StatusCode = ApiStatusCode.Failed };
        }

        /// <summary>
        /// ارسال پیامک احرازهویت
        /// </summary>
        /// <param name="sendOtpRequest"></param>
        /// <returns></returns>
        public static async Task<SendSmsResponse> SendOtp(SendOtpRequest sendOtpRequest)
        {
            var client = new RestClient();
            var request = new RestRequest($"{ApiAddress}Messages/SendOtp", Method.Post);
            request.AddHeader("Authorization", sendOtpRequest.Token);
            request.AddHeader("Content-Type", "application/json");
            var body = new SendOtpRequest
            {
                SenderNumber = sendOtpRequest.SenderNumber,
                RecipientNumbers = sendOtpRequest.RecipientNumbers,
                OtpId = sendOtpRequest.OtpId,
                Parameters = sendOtpRequest.Parameters
            };
            var jsonBody = JsonSerializer.Serialize(body);
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);
            var response = await client.ExecuteAsync(request);
            if (response.Content != null)
                return JsonSerializer.Deserialize<SendSmsResponse>(response.Content, DefaultSerializerSettings) ??
                       new SendSmsResponse { StatusCode = ApiStatusCode.Failed };

            return new SendSmsResponse { StatusCode = ApiStatusCode.Failed };
        }

    }
}