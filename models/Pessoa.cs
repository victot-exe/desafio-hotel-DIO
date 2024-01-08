using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_hotel_DIO.models{
    public class Pessoa{

        //Removi os outro métodos construtores para evitar ambiguidade na hora de cadastrar o usuário e poder apenas com nome e sobrenome.
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    }
}