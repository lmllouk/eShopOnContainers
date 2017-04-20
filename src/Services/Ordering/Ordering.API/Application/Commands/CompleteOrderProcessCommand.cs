﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Ordering.API.Application.Commands
{
    public class CompleteOrderProcessCommand : IAsyncRequest<bool>
    {

        [DataMember]
        public int OrderNumber { get; private set; }

        public CompleteOrderProcessCommand(int orderNumber)
        {
            OrderNumber = orderNumber;
        }
    }
}