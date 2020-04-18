﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DarkLegion.RuCaptcha
{
    public class RuCaptchaException : Exception
    {
        public RuCaptchaException()
        {

        }
        public RuCaptchaException(string message)
            : base(message)
        {

        }
        public RuCaptchaException(string message, Exception inner)
            : base(message, inner)
        {

        }

    }
}
