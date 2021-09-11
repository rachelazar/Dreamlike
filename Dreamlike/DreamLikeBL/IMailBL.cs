using System;
using System.Collections.Generic;
using System.Text;

namespace DreamLikeBL
{
    public interface IMailBL 
    {
        bool SendMailAsync(string subject, string message, string address);
    }
}
