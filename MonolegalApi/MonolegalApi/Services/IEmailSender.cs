using System.Threading.Tasks;

namespace MonolegalApi.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }

}

