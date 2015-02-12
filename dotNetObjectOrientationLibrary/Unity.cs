using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace dotNetObjectOrientationLibrary.Unity
{
    public class MessageWriter : IMessageWriter
    {
        public event EventHandler RaiseCustomEvent;

        public virtual void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class SecureMessageWriter : EncryptionMessageWriter
    {
        private int userId;
        private const int VALID_USER_ID = 1;

        public SecureMessageWriter(int userId)
        {
            this.userId = userId;
        }

        //public SecureMessageWriter(IAuthenticationService authenticationService)
        //{
        //    this.AuthenticationService = authenticationService;
        //}

        //[Dependency]
        //public IAuthenticationService AuthenticationService { get; set; }

        //public SecureMessageWriter()
        //{
        //}

        public override void WriteMessage(string message)
        {
            //this.userId = this.AuthenticationService.GetAuthenticatedUserId();
            if (this.userId == VALID_USER_ID)
            {
                base.WriteMessage(message + " and user " + this.userId);
            }
            else
            {
                Console.WriteLine("Unauthorized user");
            }
        }
    }

    public class EncryptionMessageWriter : MessageWriter
    {
        public override void WriteMessage(string message)
        {
            var encryptedMessage = message.Replace("a", "*").Replace("e", "*").Replace("i", "*").Replace("o", "*").Replace("u", "*");
            base.WriteMessage(encryptedMessage);
        }
    }

    public class UnityLifeTime
    {
        private static int Instances = 0;

        private int instance = 0;

        public UnityLifeTime()
        {
            instance = ++Instances;
        }

        public void PrintInstance()
        {
            Console.WriteLine(this.instance);
        }
    }
}
