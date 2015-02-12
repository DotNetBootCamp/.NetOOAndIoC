using dotNetObjectOrientationLibrary;
//using dotNetObjectOrientationLibrary.Decorator;
//using dotNetObjectOrientationLibrary.Inheritance;
//using dotNetObjectOrientationLibrary.Unity;
using dotNetUnity;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetObjectOrientation
{
    public class Program
    {
        private const string MESSAGE = "Hello World!";
        private const int USER_ID = 1;

        public static void Main(string[] args)
        {
            //INHERITANCE

            IMessageWriter messageWriter = new MessageWriter();  //be careful with var
            messageWriter.WriteMessage(MESSAGE);

            //messageWriter = new EncryptionMessageWriter();
            //messageWriter.WriteMessage(MESSAGE);

            //messageWriter = new SecureMessageWriter(USER_ID);
            //messageWriter.WriteMessage(MESSAGE);

            //DECORATOR

            //IMessageWriter messageWriter = new MessageWriter();
            //messageWriter.WriteMessage(MESSAGE);

            //messageWriter = new EncryptionMessageDecorator(messageWriter);
            //messageWriter.WriteMessage(MESSAGE);

            //messageWriter = new SecureMessageWriterDecorator(messageWriter, USER_ID);
            //messageWriter.WriteMessage(MESSAGE);

            //DI

            Bootstrapper.Initialise();
            //var messageWriter = Bootstrapper.UnityContainer.Resolve<MessageWriter>();
            //messageWriter.WriteMessage(MESSAGE);

            //var messageWriter = Bootstrapper.UnityContainer.Resolve<IMessageWriter>();
            //messageWriter.WriteMessage(MESSAGE);

            //var messageWriter = Bootstrapper.UnityContainer.Resolve<IMessageWriter>(new ParameterOverride("userId", USER_ID));
            //messageWriter.WriteMessage(MESSAGE);

            //var messageWriter = Bootstrapper.ChildContainer.Resolve<IMessageWriter>();
            //messageWriter.WriteMessage(MESSAGE);

            //var unityLifeTime = Bootstrapper.UnityContainer.Resolve<UnityLifeTime>();
            //unityLifeTime.PrintInstance(); 
            //unityLifeTime = Bootstrapper.UnityContainer.Resolve<UnityLifeTime>();
            //unityLifeTime.PrintInstance(); 
            //unityLifeTime = Bootstrapper.ChildContainer.Resolve<UnityLifeTime>();
            //unityLifeTime.PrintInstance();

            Console.Read();
        }
    }
}
