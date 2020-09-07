using Operations.Interfaces;

namespace Operations.Implementations
{
    public class Messaging : IMessaging
    {
        public const string HelloWordMessage = "Hello World";

        public virtual string GetMessage()
        {
            return HelloWordMessage;
        }
    }
}