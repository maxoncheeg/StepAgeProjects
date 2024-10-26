using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace JordanThingsServer.Model.Commands
{
    internal class ChangePasswordCommand : IClientCommand
    {
        public void Script(NetworkStream networkStream, StreamReader streamReader, StreamWriter streamWriter)
        {
            string mail = streamReader.ReadLine();
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 465);
            NetworkCredential credential = new NetworkCredential("maxoncheeg@gmail.com", "33424324mA");
            smtpClient.Credentials = credential;
            MailMessage message = new MailMessage();
            message.From = new MailAddress("maxoncheeg@gmail.com");
            message.To.Add(new MailAddress("maxoncheeg@gmail.com"));
            message.Subject = "MVVM MAN REAL GOOD SHIT";
            message.Body = "POLNIY BALDEZH CHUVAK!";
            smtpClient.EnableSsl = true;
            smtpClient.Send(message);

        }
    }
}
