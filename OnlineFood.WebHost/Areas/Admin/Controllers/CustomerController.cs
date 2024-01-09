﻿using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Customers.Commands.Requests;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class CustomerController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult New()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> New(CreateCustomerCommand command)
    {
        return View();
    }
}
