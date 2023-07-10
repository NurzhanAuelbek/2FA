using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace _2FA
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountSid = "Key";
            var authToken = "Key";
            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Join Earth's mightiest heroes. Like Kevin Bacon.",
                from: new Twilio.Types.PhoneNumber("+13254201107"),
                to: new Twilio.Types.PhoneNumber("+77007001455")
            );

            Console.WriteLine(message.Sid);
        }
    }
}
