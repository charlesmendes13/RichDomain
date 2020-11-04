using FluentValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace RichDomain.Domain.ValueObject
{
    public class Telefone : Notifiable
    {
        public Telefone(string ddd, string numero)
        {
            DDD = ddd;
            Numero = numero;
        }

        public string DDD { get; private set; }
        public string Numero { get; private set; }
    }
}
