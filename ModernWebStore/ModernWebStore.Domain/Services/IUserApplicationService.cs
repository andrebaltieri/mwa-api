using ModernWebStore.Domain.Commands.UserCommands;
using ModernWebStore.Domain.Entities;

namespace ModernWebStore.Domain.Services
{
    public interface IUserApplicationService
    {
        User Register(RegisterUserCommand command);
        User Authenticate(string email, string password);
    }
}
