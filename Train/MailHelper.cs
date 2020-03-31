using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
namespace Train
{
    class MailHelper
    {
        MailMessage message;
        // 완료
        public MailHelper()
        {
            message = new MailMessage();
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.From = new System.Net.Mail.MailAddress("kimsh9167@naver.com");


        }

        public void SendMail(string name, string id, string pw, string ToMail)
        {
            message.To.Add(ToMail);
            message.Subject = name + "님의 계정 정보가 이메일로 도착했습니다.";
            message.SubjectEncoding = System.Text.Encoding.UTF8;

            message.Body = "ID : " + id + "     PW : " + pw;
            message.BodyEncoding = System.Text.Encoding.UTF8;

            try
            {
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.naver.com", 587);
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtp.Credentials = new System.Net.NetworkCredential("kimsh9167","16-76017662");
                smtp.Send(message);
                MessageBox.Show("메일이 성공적으로 보내졌습니다.", "성공");
            }catch(System.Exception e)
            {
                MessageBox.Show(e.Message, "이메일 전송 실패");
            }
        }
    }
}
