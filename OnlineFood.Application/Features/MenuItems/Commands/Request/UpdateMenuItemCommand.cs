﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.Features.MenuItems.Commands.Request
{
    public class UpdateMenuItemCommand:IRequest<bool>
    {
        public int Id { get; set; }
        public DateTime CreateDate {  get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public int MenuId { get; set; }
    }
}
