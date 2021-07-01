using asdds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asdds.Services
{
    public interface ISmtpService
    {
        bool SendEmail(ContactViewModel model);
    }
}