using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Médiathèque_Online.service;
using My_Médiathèque_Online.secure;
using System.Net.Mail;

namespace My_Médiathèque_Online.controler
{ 
    class ControleurAdministre
    {
        private AdministreService admService;
        private SecureScrypt secure;

        public ControleurAdministre()
        {
            this.admService = new();
            this.secure = new();
        }
        public List<AdministreDTO> GetListAdministre()
        {
            return admService.FindAll();
        }
        public AdministreDTO GetAdministreById(long id)
        {
            return admService.FindById(id);
        }
        public AdministreDTO GetAdministreByName(string name)
        {
            return admService.FindByName(secure.Chiffrage(name));
        }
        public AdministreDTO UpdateAdministre(AdministreDTO administreDTO)
        {
            return admService.Update(administreDTO);
        }
        public bool login(string id, string pass)
        {

            System.Diagnostics.Debug.WriteLine("bool login");
            AdministreDTO administreDTO = admService.FindByLog(id, Hash.sha256_hash(pass));
            if(administreDTO != null)
            {
                if (administreDTO.Get_log_id_Administre().Equals(id) && administreDTO.Get_log_password_Administre().Equals(Hash.sha256_hash(pass)))
                {
                    Program.SetConnected(true);
                }
                else
                {
                    Program.SetConnected(false);
                }
            }
            else
            {
                Program.SetConnected(false);
            }
            return Program.IsConnected();
        }
        public long InsertAdministre(AdministreDTO administreDTO)
        {
            long admDTO = admService.Insert(administreDTO);
            //envoi du code par mail
            string to = administreDTO.Get_mail_Administre();
            string from = "ben@contoso.com";
            string server = "smtp-springs.alwaysdata.net";
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Using the new SMTP client.";
            message.Body = @"Using this new feature, you can send an email message from an application very easily.";
            SmtpClient client = new SmtpClient(server);
            // Credentials are necessary if the server requires the client
            // to authenticate before it will send email on the client's behalf.
            client.UseDefaultCredentials = true;

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }
            return admDTO;
        }
    }
}
