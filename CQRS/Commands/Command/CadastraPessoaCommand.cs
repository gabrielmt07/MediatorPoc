using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Commands.Command
{
    public class CadastraPessoaCommand : IRequest<string> //tipo de dado que sera retornado quando o command for executado
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
    }
}
