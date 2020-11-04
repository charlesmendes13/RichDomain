using FluentValidator.Validation;
using RichDomain.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace RichDomain.Domain.Validations
{
    public class NomeValidation : IContract
    {    
        public NomeValidation(Nome nome)
        {
            Contract = new ValidationContract();
            Contract
                .Requires()
                .HasMinLen(nome.PrimeiroNome, 3, "Nome.PrimeiroNome", "O Primeiro Nome deve conter no mínimo 3 caracteres")
                .HasMaxLen(nome.PrimeiroNome, 20, "Nome.PrimeiroNome", "O Primeiro Nome deve conter no máximo 20 caracteres")
                .HasMinLen(nome.UltimoNome, 3, "Nome.UltimoNome", "O Último Nome deve conter no mínimo 3 caracteres")
                .HasMaxLen(nome.UltimoNome, 50, "Nome.UltimoNome", "O Último Nome deve conter no máximo 50 caracteres");
        }

        public ValidationContract Contract { get; }
    }
}
