using FluentValidator.Validation;
using RichDomain.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace RichDomain.Domain.Validations
{
    public class EnderecoValidation : IContract
    {
        public EnderecoValidation(Endereco endereco)
        {
            Contract = new ValidationContract();
            Contract
                .Requires()
                .Matchs(endereco.Logradouro, @"^[ a-zA-ZÀ-ú0-9 ,-]*$", "Endereco.Logradouro", "O Logradouro é inválido")
                .Matchs(endereco.Numero, @"^[0-9]*$", "Endereco.Numero", "O Número é inválido")
                .Matchs(endereco.Complemento, @"^[ a-zA-ZÀ-ú0-9]*$", "Endereco.Complemento", "O Complemento é inválido")
                .Matchs(endereco.Bairro, @"^[ a-zA-ZÀ-ú0-9]*$", "Endereco.Bairro", "O Bairro é inválido")
                .Matchs(endereco.Municipio, @"^[ a-zA-ZÀ-ú0-9]*$", "Endereco.Municipio", "O Município é inválido")
                .Matchs(endereco.Estado, @"^[ a-zA-ZÀ-ú]*$", "Endereco.Estado", "O Estado é inválido")
                .HasMinLen(endereco.CEP, 9, "Endereco.CEP", "O CEP deve conter no mínimo 9 caracteres")
                .HasMaxLen(endereco.CEP, 9, "Endereco.CEP", "O CEP deve conter no máximo 9 caracteres")
                .Matchs(endereco.CEP, @"^[0-9]{5}-[\d]{3}$", "Endereco.CEP", "O CEP é inválido");
        }

        public ValidationContract Contract { get; }
    }
}
