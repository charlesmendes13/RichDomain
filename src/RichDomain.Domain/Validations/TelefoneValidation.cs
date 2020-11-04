using FluentValidator.Validation;
using RichDomain.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace RichDomain.Domain.Validations
{
    public class TelefoneValidation : IContract
    {
        public TelefoneValidation(Telefone telefone)
        {
            Contract = new ValidationContract();
            Contract
                .Requires()
                .HasMinLen(telefone.DDD, 2, "Telefone.DDD", "O DDD do Telefone deve conter no mínimo 2 caracteres")
                .HasMinLen(telefone.Numero, 8, "Telefone.Numero", "O Número de Telefone deve conter no mínimo 8 caracteres")
                .HasMaxLen(telefone.DDD, 2, "Telefone.DDD", "O DDD do Telefone deve conter no máximo 2 caracteres")                
                .HasMaxLen(telefone.Numero, 9, "Telefone.Numero", "O Número de Telefone deve conter no máximo 9 caracteres")
                .Matchs(telefone.DDD, @"^[0-9]*$", "Telefone.DDD", "O DDD do Telefone é inválido")
                .Matchs(telefone.Numero, @"^[0-9]*$", "Telefone.Numero", "O Número do Telefone é inválido");
        }

        public ValidationContract Contract { get; }
    }
}
