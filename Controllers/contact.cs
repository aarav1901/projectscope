using Microsoft.AspNetCore.Mvc;
using firstproject.Models;
using MailKit.Security;
using MimeKit;
using System.Diagnostics;
using MailKit.Net.Smtp;
using MimeKit.Text;


namespace firstproject.Controllers
{
    public class contact : Controller
    {
        public IActionResult page1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult page1(Classpro con)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("aravindhanitha847@gmail.com"));
            email.To.Add(MailboxAddress.Parse("aravindhanitha847@gmail.com"));
            email.Body = new TextPart(TextFormat.Html) { Text = $"<h1>hello new message</h1><h2>{con.full_name}</h2><h2>{con.email_id}</h2><h2>{con.subject}</h2><h2>{con.message}</h2>" };
            var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("aravindhanitha847@gmail.com", "zufu xbzs gvkv hmqt");
            smtp.Send(email);
            smtp.Disconnect(true);
            
            return View();
        }
    }
}

    

