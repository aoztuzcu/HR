using MimeKit;
using MailKit.Net.Smtp;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using HR.Application.Contracts.Persistence.Services;
using static System.Net.WebRequestMethods;

namespace HR.Persistence.Services;

public class EmailService : IEmailService
{
    public async Task SendConfirmMail(string mailAddress, string sendPassword, string managerInfo)
    {
        MimeMessage mimeMessage = new MimeMessage();
        MailboxAddress mailboxAddressFrom = new MailboxAddress("IKIZLEME MANAGER", "ikizlemeproject@gmail.com");
        MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailAddress);

        mimeMessage.From.Add(mailboxAddressFrom);
        mimeMessage.To.Add(mailboxAddressTo);

        var bodyBuilder = new BodyBuilder();
        bodyBuilder.TextBody = $"Şirket yöneticiniz {managerInfo} tarafından kaydınız yapılmıştır. Sisteme giriş yapabilmeniz için gerekli bilgiler aşağıda verilmiştir.\n" +
               $"E - Mail: {mailAddress}\n" +
                  $"Password: {sendPassword}\n" +
                     "\n" +
                     "URL: https://ikizlemehrr.azurewebsites.net/";

        mimeMessage.Body = bodyBuilder.ToMessageBody();
        mimeMessage.Subject = "Yeni Üye Kayıt Tamamlama";

        using (var smtpClient = new SmtpClient())
        {
            await smtpClient.ConnectAsync("smtp.gmail.com", 587, false);
            await smtpClient.AuthenticateAsync("ikizlemeproject@gmail.com", "crokwoumhkwvlphm");
            await smtpClient.SendAsync(mimeMessage);
            await smtpClient.DisconnectAsync(true);
        }

    }

    public async Task SendConfirmMailByAdmin(string mailAddress, string sendPassword, string adminInfo)
    {
        MimeMessage mimeMessage = new MimeMessage();
        MailboxAddress mailboxAddressFrom = new MailboxAddress("IKIZLEME MANAGER", "ikizlemeproject@gmail.com");
        MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailAddress);

        mimeMessage.From.Add(mailboxAddressFrom);
        mimeMessage.To.Add(mailboxAddressTo);

        var bodyBuilder = new BodyBuilder();
        bodyBuilder.TextBody = $"Site Yöneticiniz {adminInfo} tarafından kaydınız yapılmıştır. Sisteme giriş yapabilmeniz için gerekli bilgiler aşağıda verilmiştir.\n" +
               $"E - Mail: {mailAddress}\n" +
                  $"Password: {sendPassword}\n" +
                     "\n" +
                     "URL: https://ikizlemehrr.azurewebsites.net/";

        mimeMessage.Body = bodyBuilder.ToMessageBody();
        mimeMessage.Subject = "Yeni Üye Kayıt Tamamlama";

        using (var smtpClient = new SmtpClient())
        {
            await smtpClient.ConnectAsync("smtp.gmail.com", 587, false);
            await smtpClient.AuthenticateAsync("ikizlemeproject@gmail.com", "crokwoumhkwvlphm");
            await smtpClient.SendAsync(mimeMessage);
            await smtpClient.DisconnectAsync(true);
        }
    }
}
