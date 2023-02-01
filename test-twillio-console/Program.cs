// See https://aka.ms/new-console-template for more information

using Texter.Models;
using Twilio;
using Twilio.AspNet.Common;
using Twilio.AspNet.Core;
using Twilio.Rest.Api.V2010.Account;
using Twilio.TwiML;





Message m = new Message();

m.To = "+923242087928";

m.Body = "HI this is nabeel arif , this is a test message . Twillio !!";

m.Send();





string accountSid = EnvironmentVariables.AccountSid;
string authToken = EnvironmentVariables.AuthToken;

TwilioClient.Init(accountSid, authToken);

var message = MessageResource.Create(
    body: "HI from nabeel",
    from: new Twilio.Types.PhoneNumber("+13853964753"),
    to: new Twilio.Types.PhoneNumber("+923242087928")
);

Console.WriteLine("Success: \n"+message.Sid);



Console.WriteLine("TAdaa");




////// for incomming


SmsController sm = new SmsController();

public class SmsController : TwilioController
{
    public TwiMLResult Index(SmsRequest incomingMessage)
    {
        var messagingResponse = new MessagingResponse();
        messagingResponse.Message("The copy cat says: " +
                                  incomingMessage.Body);

        return TwiML(messagingResponse);
    }
}
