using RichDomain.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace RichDomain.Domain.Entities
{
    public class Contato : Base
    {
        public Contato(Telefone telefone)
        {
            Telefone = telefone;
        }

        public Telefone Telefone { get; private set; }
    }
}
