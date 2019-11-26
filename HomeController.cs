﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebHooks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Webhook
{
    public class HomeController : Controller
    {
        [GitHubWebHook]
        public IActionResult GitHubHandler(JObject data)
        {
            var result = JsonConvert.SerializeObject(data);
            return Ok();
        }
    }
}
