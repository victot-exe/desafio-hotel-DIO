using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_hotel_DIO.models{
    public class Reserva{
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados){
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes){
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (hospedes.Count <= this.Suite.Capacidade){
                Hospedes = hospedes;
            }
            else{
                throw new Exception($"O valor de hospedes é maior do que a capacidade do tipo de quarto {Suite.TipoSuite}");
            }
        }

        public void CadastrarSuite(Suite suite){
            Suite = suite;
        }

        public int ObterQuantidadeHospedes(){
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria(){
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = Suite.ValorDiaria * this.DiasReservados;
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (this.DiasReservados >= 10){
                return valor * 0.9M;
            }else{
                return valor;
            }
        }
    }
}