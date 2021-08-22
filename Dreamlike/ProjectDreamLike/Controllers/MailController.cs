using DreamLikeBL;
using DreamLikeDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DreamLike.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        Mail _mailBl;
        [HttpPost]
        public bool SendEmail([FromBody] MailDTO mail)
        {
            var m = _mailBl.SendEmail(mail.subject, mail.message, mail.mail);
            return m;
        }

    }
}
