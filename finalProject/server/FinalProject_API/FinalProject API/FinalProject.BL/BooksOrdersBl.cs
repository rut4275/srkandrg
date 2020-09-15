using FinalProject.DL;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    public class BooksOrdersBl : IBooksOrdersBl
    {
        public IBooksOrdersDl booksOrdersDl;
        public BooksOrdersBl(IBooksOrdersDl _booksOrdersDl)
        {
            booksOrdersDl = _booksOrdersDl;
        }

        public async Task CreateNewOrder(BooksOrders booksOrders)
        {
            await booksOrdersDl.CreateNewOrder(booksOrders);
        }

        public async Task<List<BooksOrders>> GetOrders()
        {
            return await booksOrdersDl.GetOrders();
        }

        public async Task<bool> PutOrders(BooksOrders booksOrders)
        {
            await booksOrdersDl.PutOrders(booksOrders);

            //sendEmail();
            //var message = new Message(new string[] { "srk34389@gmail.com" }, "Test email", "This is the content from our email.");
            //emailSender.SendEmail(message);
            //var files = Request.Form.Files.Any() ? Request.Form.Files : new FormFileCollection();
            //var message = new Message(new string[] { "codemazetest@mailinator.com" }, "Test mail with Attachments", "This is the content from our mail with attachments.", files);
            //await emailSender.SendEmailAsync(message);
            

            //לעשות תנאי אם שולם
            string[] files = 
            { "C:\\ruti\\FinalProject\\files\\1.txt",
               "C:\\ruti\\FinalProject\\files\\2.txt",
               "C:\\ruti\\FinalProject\\files\\3.txt",
               "C:\\ruti\\FinalProject\\files\\4.txt" };
            string contactEmail = "";
            bool[] arrBooks = new bool[10];
            
            contactEmail = booksOrders.Customer.Contact.ContactEmail;
            foreach (var item in booksOrders.BooksOrderItem)
            {
                switch (item.BookId)
                {
                    case 1:
                        arrBooks[0] = true;
                        break;
                    case 2:
                        arrBooks[0] = true;
                        break;
                    case 3:
                        arrBooks[1] = true;
                        break;
                    case 4:
                        arrBooks[1] = true;
                        break;
                    case 5:
                        arrBooks[2] = true;
                        break;
                    case 6:
                        arrBooks[2] = true;
                        break;
                    case 7:
                        arrBooks[2] = true;
                        break;
                    case 8:
                        arrBooks[2] = true;
                        break;
                }

            }
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("srk34389@gmail.com");
                mail.To.Add(contactEmail);
                mail.Subject = "מדריך / מדריכים למורה סוד ההבעה";
                mail.Body = "שלום לך מורה יקרה!" + "\n" +
                    "מצורפים כאן קבצי העזר עבור ספרי סוד ההבעה שהוזמנו" + "\n" +
                    "שנת למידה מבורכת:)" + "\n" +
                    "מירי ואסתי";
                System.Net.Mail.Attachment attachment;

                if (arrBooks[0])
                {
                    attachment = new System.Net.Mail.Attachment(files[0]);
                    mail.Attachments.Add(attachment);
                }
                if (arrBooks[1])
                {
                    attachment = new System.Net.Mail.Attachment(files[1]);
                    mail.Attachments.Add(attachment);
                }
                if (arrBooks[2])
                {
                    attachment = new System.Net.Mail.Attachment(files[2]);
                    mail.Attachments.Add(attachment);
                    attachment = new System.Net.Mail.Attachment(files[3]);
                    mail.Attachments.Add(attachment);
                }

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("rut.programming@gmail.com", "dukeruczvnu,d");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        

    }
}
