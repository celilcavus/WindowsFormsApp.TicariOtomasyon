using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp.TicariOtomasyon.Views
{
    public partial class FrmMail : XtraForm
    {
        public FrmMail()
        {
            InitializeComponent();
        }
        public string Mail;
        private void FrmMail_Load(object sender, EventArgs e)
        {
            txtMail.Text = Mail.ToString();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            //MailMessage message = new MailMessage();
            //SmtpClient client = new SmtpClient();

            //client.Credentials = new System.Net.NetworkCredential("celilcavus13@gmail.com", "Sensizlik123");
            //client.Port = 587;
            //client.Host = "smtp.hotmail.com";
            //client.EnableSsl = true;
            //message.To.Add(txtMail.Text);
            //message.From = new MailAddress("celilcavus13@gmail.com");
            //message.Subject = txtKonu.Text;
            //message.Body = txtMesaj.Text;
            //client.Send(message);


        }
    }
}
