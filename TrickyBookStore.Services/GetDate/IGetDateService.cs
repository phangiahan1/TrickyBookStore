﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyBookStore.Services.GetDate
{
    public interface IGetDateService
    {
        DateTimeOffset getStartDate(int year, int month);
        DateTimeOffset getEndDate(int year, int month);
    }
}
