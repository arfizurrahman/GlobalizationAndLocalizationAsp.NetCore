﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlobalizationLocalizationWebApp.Resources;
using Microsoft.AspNetCore.Mvc;

namespace GlobalizationLocalizationWebApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly LocalizationService _localizationService;

        public CustomerController(LocalizationService localizationService)
        {
            _localizationService = localizationService;
        }
        [HttpGet]
        public IActionResult Create()
        {
            var fullName = _localizationService.GetLocalizedHtmlString("FullName");
            var city = _localizationService.GetLocalizedHtmlString("City");
            var mobileNo = _localizationService.GetLocalizedHtmlString("MobileNo");
            return View();
        }
    }
}
