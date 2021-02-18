using System;

namespace SingleResponsibility
{
    public class UserService
    {
       public void Register(string email, string password)
        {
            //Added EmailService reference
            EmailService emailService = new EmailService();

            if (!emailService.ValidateEmail(email))
                throw new ValidationException("Email is not an email");
            var user = new User(email, password);

            emailService.SendEmail(user);
        }

        public void Login(string email, string password)
        {
            Console.WriteLine("Login");
        }

        //Moved ValidateEmail & SendEmail to EmailService class
    }
}
