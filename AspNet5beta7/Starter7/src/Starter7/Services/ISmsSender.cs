﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starter7.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
