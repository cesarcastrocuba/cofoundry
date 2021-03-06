﻿using Cofoundry.Core.Mail;
using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cofoundry.Domain.MailTemplates
{
    public class NewUserWelcomeMailTemplate : IMailTemplate
    {
        public string ViewFile
        {
            get { return TemplatePath.ViewPath + "Users/NewUserWelcomeMail"; }
        }

        public string Subject
        {
            get { return "Welcome to Cofoundry"; }
        }

        #region custom properties

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public HtmlString TemporaryPassword { get; set; }

        #endregion
    }
}
