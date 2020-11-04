using FluentValidator.Validation;
using RichDomain.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace RichDomain.Domain.Validations
{
    public class EmailValidation : IContract
    {
        public EmailValidation(Email email)
        {
            Contract = new ValidationContract();
            Contract
                .Requires()
                .IsEmail(email.Endereco, "Email.Endereco", "O Endereço de E-mail é inválido");
        }

        public ValidationContract Contract { get; }
    }
}
