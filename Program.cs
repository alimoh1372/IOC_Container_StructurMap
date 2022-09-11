using System;
using StructureMap;
using Services;

namespace IOC_Container_StructurMap
{
    class Program
    {
        static void Main(string[] args)
        {
            // تنظیمات اولیه برنامه که فقط یکبار باید در طول عمر برنامه انجام شود

            var container = new Container(x =>
            {
                x.For<IEmailsService>().Use<EmailsService>();
                x.For<IUsersService>().Use<UsersService>();
            }
            );

            var emailservice = container.GetInstance<IEmailsService>();

            emailservice.SendEmailToUser(5,"email test","test structureMap as IOC container");

            Console.ReadKey();
        }
    }
}
