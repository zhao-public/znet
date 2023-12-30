using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Net.Mail
{
    public interface IMailSender
    {
        Task SendAsync();
    }
}
