using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.services
{
    public interface IMailService
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}