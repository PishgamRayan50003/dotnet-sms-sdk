using System.ComponentModel;

namespace PishgamRayan.Sms.Sdk
{
    public enum ApiStatusCode : byte
    {
        [Description("موفقیت آمیز")]
        Successful,
        [Description("ارسال تکی انجام شده است")]
        SingleSent,
        [Description("ارسال نظیر به نظیر انجام شده است")]
        P2PSent,
        [Description("عدم شکست")]
        NotFailure,
        [Description("تعداد گیرندگان با تعداد پیامک همخوانی ندارد")]
        MessageBodiesNotEqualToRecipientNumbers,
        [Description("متن پیامک دارای کلمه(کلمات) فیلتر شده است")]
        SmsTextIsFilter,
        [Description("مجاز به ارسال لینک در متن پیام نمی باشید")]
        LinkIsNotAllowed,
        [Description("لیست گیرندگان خالی است")]
        RecipientsIsEmpty,
        [Description("سازمان یافت نشد یا غیر فعال است یا احراز هویت نشده یا ارسال آن غیر فعال است")]
        OrganizationNotFound,
        [Description("سازمان غیر فعال است")]
        OrganizationIsInactive,
        [Description("سازمان منقضی شده است")]
        OrganizationIsExpired,
        [Description("سازمان جاری یا یکی از سازمان های پدر غیرفعال است یا احراز هویت نشده یا ارسال آن ها غیر فعال است")]
        OrganizationOrHierarchyIsInactive,
        [Description("زمان ارسال خارج از بازه مجاز سازمان می باشد")]
        OrganizationSendTimeNotValid,
        [Description("ارسال کاربر غیر فعال است")]
        UserSendInactive,
        [Description("کاربر منقضی شده است")]
        UserIsExpired,
        [Description("اطلاعات کاربر پیدا نشد یا احراز هویت انجام نشده یا ارسال کاربر یا کاربر غیر فعال است")]
        UserNotFound,
        [Description("سازمان والد منقضی شده است")]
        ParentOrganizationIsExpired,
        [Description("شماره فرستنده معتبر یا فعال نیست، یا قابلیت ارسال از شما گرفته شده است")]
        PrivateNumberNotValid,
        [Description("شماره فرستنده غیرفعال است")]
        PrivateNumberIsInactive,
        [Description("شماره فرستنده منقضی شده است")]
        PrivateNumberIsExpired,
        [Description("سرویس ارسال در دسترس نمی باشد")]
        SystemIsOutOfService,
        [Description("خطا در ثبت در صف ارسال")]
        ErrorInScheduledMessagesInsert,
        [Description("لیست گیرندگان با توجه به لیست سیاه خالی است")]
        ReceiverListBaseBlackListIsEmpty,
        [Description("تعداد گیرندگان با توجه با بخش های پیامک بیشتر از 100 است")]
        RecipientCountNotValid,
        [Description("متن پیامک خالی است")]
        MessageBodiesIsEmpty,
        [Description("ناموفق")]
        Failed,
        [Description("تعداد گیرندگان بیشتر از 100 است")]
        MaxRecipientsIs100,
        [Description("خطا در ثبت در صف")]
        ErrorInAddToRabbit,
        [Description("شروع درخواست")]
        BeginRequest,
        [Description("پارامترها با پیام تعریف شده همخوانی ندارد")]
        ParametersNotMatchMessage,
        [Description("پارامترهای پیام نامعتبر")]
        ParametersIsNull,
        [Description("اطلاعات قالب پیامک احرازهویت یافت نشد")]
        OtpNotFound,
        [Description("ارسال قالب پیامک احرازهویت انجام شده است")]
        OtpSent,
        [Description("توکن وارد نشده است")]
        TokenIsNull,
        [Description("توکن یافت نشد یا اشتباه وارد شده است یا تایید نشده است")]
        TokenNotFound,
        [Description("آی پی نامعتبر است")]
        IpIsInvalid,
        [Description("خطا در حذف بلک لیست ها")]
        RemoveBlackListError,
        [Description("تاریخ شروع یا پایان به اشتباه وارد شده است")]
        DatesIsInvalid,
        [Description("خطا در چک کردن استثناء ها ")]
        CheckSendSmsExceptionError,
        [Description("خطا در دریافت اطلاعات توکن")]
        GetTokenInfoError,
        [Description("خط امکان ارسال صوتی را ندارد")]
        PrivateNumberNotSendVoice,
        [Description("ارسال رمز یکبار مصرف صوتی انجام شد")]
        VoiceOtpSent,
        [Description("کد دلخواه باید حداقل 4 و حداکثر 8 رقم باشد")]
        OptionalCodeLengthInvalid,
        [Description("شماره همراه یا ثابت وارد نشده است")]
        NumberIsEmpty,
        [Description("شماره فرستنده وارد نشده است")]
        SenderNumberIsEmpty,
        [Description("مشکل در کسر هزینه")]
        DecreaseSendPriceError,
        [Description("خطا در ثبت در صندوق ارسال و حذف از صف")]
        ErrorInsertOutBoxMessageDeleteScheduledMessage,
        [Description("عنوان وارد نشده است")]
        TitleIsEmpty,
        [Description("فایل وارد نشده است")]
        FileIsEmpty,
        [Description("فرمت فایل معتبر نیست")]
        FileFormatNotValid,
        [Description("آپلود فایل صوتی انجام شد")]
        FileUploaded,
        [Description("فایل صوتی تایید نشده")]
        VoiceNotAccepted,
        [Description("شناسه صوتی یافت نشد")]
        VoiceNotFound,
        [Description("حداکثر تلاش باید بزرگتر از صفر باشد")]
        MaxTryCountMustGreaterZero,
    }

    public enum DeliveryStatus
    {
        [Description("ارسال شده به اپراتور")] SentToItc = 3,
        [Description("رسیده به مخابرات")] ReceivedByItc = 4,
        [Description("لیست سیاه")] BlackList = 14,
        [Description("جدول لیست سیاه")] BlackListTable = 30,
        [Description("فرستنده معتبر نیست")] InvalidSender = 26,
        [Description("ارسال نشده")] NotSent = 10,
        [Description("رسیده به گوشی")] SentAndReceivedbyPhone = 1,
        [Description("نرسیده به گوشی")] HaveNotReceivedToPhone = 2,
        [Description("نرسیده به مخابرات")] DidNotReceiveToItc = 5,

        [Description("پیامک توسط سرور دریافت نشد")]
        NotReceivebyServer = 6,

        [Description("متن پیامک فیلتر میباشد")]
        SmsIsFilter = 15,
        [Description("ارسال شد")] Sent = 9,
        [Description("کمبود اعتبار")] NotEnoughBalance = 18,

        [Description("نام کاربری یا رمز عبور اشتباه است")]
        InvalidUserOrPassword = 24,
        [Description("موبایل معتبر نیست")] InvalidMobile = 27,
        [Description("ذخیره شده")] Stored = 29,

        [Description("متن پیام حاوی لینک است")]
        SmsTextContainLink = 37,

        [Description("شماره گیرنده از طرف اپراتور پشتیبانی نمی شود")]
        NotSupportNumberFromOperator = 47,
        [Description("خطا در ارسال")] ErrorInSending = 7,
        [Description("منتظر ارسال")] WaitingForSend = 8,
        [Description("در حال ارسال")] IsSending = 12,
        [Description("در انتظار تایید")] WaitingForConfirmation = 17,
        [Description("متن پیام خالی است")] TextIsEmpty = 22,
        [Description("تایید نشده")] Rejected = 33,
        [Description("شناسه پیامک یافت نشد")] SmsIdNotFound = 34,
        [Description("در صف ارسال")] InQueue = 35,
        [Description("متن پیام نامعتبر است")] InvalidSmsText = 36,

        [Description("بسته ارسالی بیشتر از 100")]
        PacketGreaterThan100 = 38,

        [Description("تعداد پیام و شماره همخوانی ندارد")]
        MessagesCountAndNumberCountNotMatch = 39,
        [Description("زمان ارسال نامتعبرست")] InvalidSendTime = 40,

        [Description("تعداد پیام و کدینگ همخوانی ندارد")]
        MessageCountAndCodingCountNotMatch = 41,

        [Description("اپراتور پشتیبانی نمیشود")]
        OperatorNotSupport = 42,
        [Description("تعرفه غیر معتبرست")] InvalidGroupPrice = 43,

        [Description("کدینگ پیام پشتیبانی نمیشود")]
        CodingNotSupport = 44,

        [Description("خط ارسال کننده غیرفعال")]
        PrivateNumberInActive = 45,
        [Description("خط ارسال کننده منقضی")] PrivateNumberExpired = 46,
        [Description("زمان ارسال غیر مجاز")] IllegalSendTime = 48,

        [Description("لغو از سوی کاربر(لغو11)")]
        CanceledFromReceiver = 49,
        [Description("کدینگ غیرمجاز")] InvalidCoding = 50,
        [Description("لغو از سوی اپراتور")] CanceledFromOperator = 51,
        [Description("منقضی از سوی اپراتور")] ExpiredFromOperator = 52,
        [Description("ردشده از سمت اپراتور")] RejectFromOperator = 53,
        [Description("نام کاربری یافت نشد")] UserNameNotFound = 54,
        [Description("کاربر منقضی")] UserExpired = 55,
        [Description("کاربر غیرفعال")] InActiveUser = 56,
        [Description("udh نامعتبر")] UdhIsWrong = 57,

        [Description("خطای سیستم از سوی اپراتور")]
        OperatorSystemError = 58,
        [Description("غیرمجاز")] NotAccess = 59,
        [Description("ردشده توسط مخابرات")] RejectByItc = 60,
        [Description("درخواست نامعتبر")] InvalidRequest = 61,

        [Description("خط ارسال کننده بلاک شده است")]
        PrivateNumberIsBlocked = 62,
        [Description("اپراتور در دسترس نیست")] OperatorNotAvailable = 63,
        [Description("نامشخص")] Unknown = 0,
    }

    public enum SendVoiceOtpErrors
    {
        WithoutError = 0,
        [Description("شماره اشتباه میباشد")] InvalidCellPhone = -2,
        [Description("عدم موجودی کافی")] NotEnoughBalance = -3,
        [Description("طول کد غیرمجاز")] InvalidCodeLength = -5,

        [Description("زمان ارسال غیرمجاز میباشد")]
        InvalidSendTime = -6,

        [Description("امکان اتصال به سرور وجود ندارد")]
        CannotConnectToServer = -20,

        [Description("ثبت OTP غیرفعال میباشد")]
        InActiveOtp = -25,
        [Description("خطایی رخ داده است")] ServerError = -500
    }

    public enum VoiceAuthorizationErrors
    {
        WithoutError = 0,

        [Description("نام کاربری یا رمز عبور اشتباه است")]
        InvalidUserNameOrPassword = -1,
        [Description("عدم احراز هویت")] Forbidden = -10,
        [Description("خطای ناشناخته")] Unknown = -20,
        [Description("عدم مجوز وب سرویس")] NotAllowWebService = -100,
        [Description("عدم احراز موبایل")] MobileNotConfirm = -101,
        [Description("کاربری منقضی شده")] UserExpired = -102
    }

    public enum VoiceUploadErrors
    {
        WithoutError = 0,
        InvalidFormat = -10,
        ErrorInConversion = -20,
        ServerError = -500
    }

    /// <summary>
    /// وضعیت تایید صوت
    /// </summary>
    public enum VoiceStatus : byte
    {
        [Description("در انتظار تایید")] AwaitingConfirmation,
        [Description("تایید شده")] Accepted,
        [Description("رد شده")] Failed,
        [Description("در انتظار تائید تلفنی")] AwaitingPhoneConfirmation
    }
}