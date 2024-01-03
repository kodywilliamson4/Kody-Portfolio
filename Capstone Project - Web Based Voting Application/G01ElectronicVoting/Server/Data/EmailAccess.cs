using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using Newtonsoft.Json;
using G01ElectronicVoting.Shared;
using G01ElectronicVoting.Client;
using System.IO;
using System.Net.Mime;

namespace G01ElectronicVoting.Server.Data
{
    public class EmailAccess
    {
        //Election election = new();
        /*string title;
        public string SetElection(string t)
        {
            title = t;
            return title;
            //  string t = title;
            //return title;
            //Election e = new();
           
            //election = e;
        }*/
        public bool EmailElectorate(string voter, string eTitle, string eCreator)
        {
            bool emailSent;
           
           // string eTitle = title;
            //Election e2 = new();

            //EmailAccess access = new();
            //access.SetElection(e2);
            //SetElection(e);

            if (voter == null)
            {
                emailSent = false;
                return emailSent;
            }

            string emailPass = File.ReadAllText("EmailPassword/GoVotePass.txt");

            SmtpClient client = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential("govote0101@gmail.com", emailPass)   
            };

            MailAddress fromEmail = new MailAddress("govote0101@gmail.com", "GoVote01 BGSU"); //changed lastname from GoVote01 to BGSU, may take a way a min to update through google
            MailAddress toEmail = new MailAddress(voter, "Electorate");
            MailMessage mailMessage = new MailMessage(fromEmail, toEmail);
            mailMessage.Subject = "You've been invited to participate in an online election on GoVote!";
            mailMessage.IsBodyHtml = true;
            string attachmentPath = Environment.CurrentDirectory + @"\img\email-Logo.png";
            Attachment inline = new Attachment(attachmentPath);
            inline.ContentDisposition.Inline = true;
            inline.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
            inline.ContentId = "contentId";
            inline.ContentType.MediaType = "image/png";
            inline.ContentType.Name = Path.GetFileName(attachmentPath);
            mailMessage.Attachments.Add(inline);
            string htmlBody = "<img src=\"cid:contentID\"> <br> <p> Hi! You've just been invited to participate in the online election " + eTitle + " on GoVote by " + eCreator +  "! Log in or create an account on the GoVote app to view the election you were just " +
                "invited to participate in, and be sure to check out the deadline that you have to cast your vote by. </p> <br> <br> Happy Voting!!";
            mailMessage.Body = htmlBody;
            /*mailMessage.Body = "Hi! You've just been invited to participate in the online election "+ eTitle +" on GoVote! Log in or create an account on the GoVote app to view the election you were just " +
                "invited to participate in, and be sure to check out the deadline that you have to cast your vote by. \n\nHappy Voting!";*/
            mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            
            try
            {
                client.Send(mailMessage);
                emailSent = true;
                return emailSent;
            }
            catch
            {
                emailSent = false;
                return emailSent;
            }
            
        }
    }
}
