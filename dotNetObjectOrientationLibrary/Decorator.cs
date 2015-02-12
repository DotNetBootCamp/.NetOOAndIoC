using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetObjectOrientationLibrary.Decorator
{
    public sealed class MessageWriter : IMessageWriter
    {
        public event EventHandler RaiseCustomEvent;

        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    public abstract class MessageWriterDecorator : IMessageWriter
    {
        protected IMessageWriter MessageWriter { get; private set; }
        public event EventHandler RaiseCustomEvent;

        public MessageWriterDecorator(IMessageWriter MessageWriter)
        {
            this.MessageWriter = MessageWriter;
        }

        public virtual void WriteMessage(string message)
        {
            MessageWriter.WriteMessage(message);
        }
    }

    public class SecureMessageWriterDecorator : MessageWriterDecorator, IMessageWriter
    {
        private int userId;
        private const int VALID_USER_ID = 1;

        public SecureMessageWriterDecorator(IMessageWriter messageWriter, int userId)
            : base(messageWriter)
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

    public class EncryptionMessageDecorator : MessageWriterDecorator, IMessageWriter
    {
        public EncryptionMessageDecorator(IMessageWriter messageWriter)
            : base(messageWriter)
        {
        }

        public override void WriteMessage(string message)
        {
            var encryptedMessage = message.Replace("a", "*").Replace("e", "*").Replace("i", "*").Replace("o", "*").Replace("u", "*");
            base.WriteMessage(encryptedMessage);
        }
    }
}
