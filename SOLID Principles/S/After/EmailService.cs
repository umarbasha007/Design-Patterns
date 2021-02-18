using System;

namespace SingleResponsibility
{
    public class EmailService
    {
        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        
        public void SendEmail(User message) => Console.WriteLine("send message");
    }
}