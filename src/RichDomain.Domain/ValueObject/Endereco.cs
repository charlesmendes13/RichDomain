using FluentValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace RichDomain.Domain.ValueObject
{
    public class Endereco : Notifiable
    {
        public Endereco(string logradouro,
            string numero,
            string complemento,
            string bairro,
            string municipio,
            string estado,
            string cep)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Municipio = municipio;
            Estado = estado;
            CEP = cep;
        }

        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Municipio { get; private set; }
        public string Estado { get; private set; }
        public string CEP { get; private set; }
    }
}
