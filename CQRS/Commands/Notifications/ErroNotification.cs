﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Commands.Notifications
{
    public class ErroNotification : INotification
    {
        public string Excecao { get; set; }
        public string PilhaErro { get; set; }
    }

}
