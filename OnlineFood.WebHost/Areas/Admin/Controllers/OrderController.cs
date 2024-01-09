﻿using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Orders.Commands.Requests;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class OrderController : Controller
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
    public async Task<IActionResult> New(CreateOrderCommand command)
    {
        return View();
    }
}
