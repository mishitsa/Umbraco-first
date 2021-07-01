using asdds.Services;
using Umbraco.Core.Composing;
using Umbraco.Core;

namespace asdds.Composing
{
    public class RegisterServicesComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<ISmtpService, SmtpService>(Lifetime.Singleton);
        }
    }
}