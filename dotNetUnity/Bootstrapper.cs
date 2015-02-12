using dotNetObjectOrientationLibrary;
using Microsoft.Practices.Unity;

//using dotNetObjectOrientationLibrary.Decorator;
//using dotNetObjectOrientationLibrary.Inheritance;
using dotNetObjectOrientationLibrary.Unity;

namespace dotNetUnity
{
    public static class Bootstrapper
    {
        public static IUnityContainer UnityContainer { get; private set; }

        //public static IUnityContainer ChildContainer { get; private set; }

        public static void Initialise()
        {
            UnityContainer = BuildUnityContainer();
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();   

            //BASIC TYPE
            //container.RegisterType<MessageWriter>();

            //BASIC INTERFACE
            //container.RegisterType<IMessageWriter, MessageWriter>();
            //container.RegisterType<IMessageWriter, EncryptionMessageWriter>();

            //CONSTRUCTOR INJECTION / PARAMETER OVERRIDE
            //container.RegisterType<IMessageWriter, SecureMessageWriter>();
            //container.RegisterType<IMessageWriter, SecureMessageWriter>(new InjectionConstructor(1));

            //NAMED INSTANCES
            //container.RegisterType<IMessageWriter, MessageWriter>("vanilla");
            //container.RegisterType<IMessageWriter, EncryptionMessageWriter>("encrypt");
            //container.RegisterType<IMessageWriter, SecureMessageWriter>("secure", new InjectionConstructor(1));

            //REFACTORED SECUREMESSAGEWRITER
            //container.RegisterType<IMessageWriter, SecureMessageWriter>();
            //container.RegisterType<IAuthenticationService, AuthenticationService>();

            //INTERNAL / INTERNALSVISIBLETO
            //container.RegisterType<IAuthenticationService, AuthenticationService>();
            //container.RegisterType<IMessageWriter, SecureMessageWriter>();

            //INJECTION FACTORY
            //container.RegisterType<IAuthenticationService, AuthenticationService>();
            //container.RegisterType<IMessageWriter, SecureMessageWriter>(
            //    new InjectionFactory((con) => new SecureMessageWriter(con.Resolve<IAuthenticationService>()))
            //);

            //CHILD CONTAINER
            //container.RegisterType<IMessageWriter, MessageWriter>();
            //ChildContainer = container.CreateChildContainer();
            //ChildContainer.RegisterType<IMessageWriter, EncryptionMessageWriter>();

            //LIFETIMES
            //container.RegisterType<UnityLifeTime>(new ContainerControlledLifetimeManager()); 
            //container.RegisterType<IMessageWriter, MessageWriter>();
            //ChildContainer = container.CreateChildContainer();

            //PROPERTY INJECTION
            //container.RegisterType<IAuthenticationService, AuthenticationService>();
            //container.RegisterType<IMessageWriter, SecureMessageWriter>();

            return container;
        }
    }
}
