using RichDomain.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace RichDomain.Domain.Entities
{
    public class Cliente : Base
    {
        public Cliente(Nome nome,
            DateTime dataNascimento,
            Email email,
            Endereco endereco,
            List<Contato> contatos)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Email = email;
            Endereco = endereco;
            Contatos = contatos;
        }

        public Nome Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public Email Email { get; private set; }
        public Endereco Endereco { get; private set; }   
        public IReadOnlyCollection<Contato> Contatos { get; private set; }
    }
}
