using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Commands.Notifications
{
    public class PessoaExcluidaNotification : INotification
    {
        public int Id { get; set; }
        public bool IsEfetivado { get; set; }
    }

}
