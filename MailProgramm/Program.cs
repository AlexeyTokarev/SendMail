﻿using System;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);

            smtp.Credentials = new NetworkCredential("bo9zeoq0l6@mail.ru", "m41uer5flu");
            smtp.EnableSsl = true;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("bo9zeoq0l6@mail.ru", "Бот техподдержки");
            mail.To.Add("tanuharumiantseva@gmail.com");
            mail.Subject = string.Format("Hello");
            mail.Body = string.Format("<h3><b>Спокойной ночи</b></h3>");
            mail.IsBodyHtml = true;

            smtp.Send(mail);
        }
    }

    //private static async Task SendEmail()
    //{
    //    SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);

    //    smtp.Credentials = new NetworkCredential("tokalig@mail.ru", "19920710tai");
    //    smtp.EnableSsl = true;

    //    MailMessage mail = new MailMessage();
    //    mail.From = new MailAddress("tokalig@mail.ru", "Aleksey");
    //    mail.To.Add("tokalig@yandex.ru");
    //    mail.Subject = string.Format("Hello");
    //    mail.Body = string.Format("<h1>Hello world!</h1>");
    //    mail.IsBodyHtml = true;

    //    await smtp.SendMailAsync(mail);

    //}
}