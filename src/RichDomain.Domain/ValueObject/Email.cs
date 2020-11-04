using System;
using System.Collections.Generic;
using System.Text;

namespace RichDomain.Domain.ValueObject
{
    public class Email
    {
        public Email(string endereco)
        {
            Endereco = endereco;
        }

        public string Endereco { get; private set; }
    }
}
