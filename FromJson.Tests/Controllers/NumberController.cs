﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace FromJson.Tests.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class NumberController: ControllerBase
    {
        [HttpPost]
        public int AddTen([FromJson]int number)
        {
            return number+10;
        }

        [HttpPost]
        public decimal AddTenDecimal([FromJson] decimal number)
        {
            return number + 10;
        }


    }
}