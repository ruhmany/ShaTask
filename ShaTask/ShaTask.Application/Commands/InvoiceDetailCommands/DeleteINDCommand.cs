﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Application.Commands.InvoiceDetailCommands
{
    public class DeleteINDCommand : IRequest
    {
        public long ID { get; set; }
    }
}
