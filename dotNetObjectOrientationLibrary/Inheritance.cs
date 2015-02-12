using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetObjectOrientationLibrary.Inheritance
{
    public class MessageWriter : IMessageWriter
    {
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

        public override void WriteMessage(string message)
        {
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
}
