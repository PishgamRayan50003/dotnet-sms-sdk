# PishgamRayan.Sms.Sdk

[![Nuget](https://img.shields.io/nuget/v/PishgamRayan.Sms.Sdk)](https://www.nuget.org/packages/PishgamRayan.Sms.Sdk)


## To use this API you need to have an account on <a href="https://sms2.pishgamrayan.com">Pishgam Rayan Sms Panel</a>

<p>
After that you just need to create an api token based on your IP address from <a href="https://sms2.pishgamrayan.com/">create token section</a> .
</p>

## Installation
```bash
dotnet add package PishgamRayan.Sms.Sdk
```

## Usage
```csharp
using PishgamRayan.Sms.Sdk;
using PishgamRayan.Sms.Sdk.Models;

SendSmsResponse sendSmsResponse = await Pishgam.SendSms(new SendSmsRequest
{
    Token = "YOUR_TOKEN",
    MessageBodies = new[] { "your first message", "your second message", ...  },
    RecipientNumbers = new[] { "your first recipient number", "your second recipient number", ... },
    SenderNumber = "YOUR_SENDER_NUMBER"
});

if (sendSmsResponse.Status == SendSmsResponseStatus.Success)
{
    // Do something when the request was successful
}
else
{
    // Do something when the request was not successful
}
```

<p> Note: If count of "MessageBodies" and "RecipientNumbers" are eqaul the message will be sent as a peer to peer message and if not all of the messages will be sent to all of the numbers you entered.
</p>