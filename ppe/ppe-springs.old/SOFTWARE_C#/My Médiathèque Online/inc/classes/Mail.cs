using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using My_Médiathèque_Online.secure;

namespace My_Médiathèque_Online
{
    class Mail
    {

        private string user;
        private string pwd;
        private SecureScrypt secure;

        public Mail()
        {
            var appSettings = ConfigurationManager.AppSettings;
            user = appSettings["UserMail"];
            pwd = appSettings["UserPwd"];
            secure = new();
        }

        public void SendMail(string destinataire, string objectMail, string bodyMail)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(this.user, secure.DeChiffrage(this.pwd)),
                EnableSsl = true
            };
            client.Send(this.user, destinataire, objectMail, bodyMail);

        }
    }
}
