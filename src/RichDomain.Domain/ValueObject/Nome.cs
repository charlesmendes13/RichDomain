using FluentValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace RichDomain.Domain.ValueObject
{
    public class Nome : Notifiable
    {
        public Nome(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }

        public override string ToString()
        {
            return $"{PrimeiroNome} {UltimoNome}";
        }
    }
}
