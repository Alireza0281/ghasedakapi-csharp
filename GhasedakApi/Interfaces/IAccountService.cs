﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static GhasedakApi.Models.Results;

namespace GhasedakApi.Interfaces
{
    public interface IAccountService
    {
        ApiResult AccountInfo();
    }
}
