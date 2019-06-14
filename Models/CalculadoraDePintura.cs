using System;

namespace PrimeiraAplicacaoMVC.Models
{
    public class CalculadoraDePintura
    {
        private Double areaParedes;
        private Double areaTeto;
        private Double rendimento = 21.11;

        public Double calcularLitragem(Comodo comodo)
        {
            areaParedes = 2 *(comodo.Largura + comodo.Profundidade) * comodo.Altura;
            areaTeto = comodo.Largura * comodo.Profundidade;
            return (areaParedes+areaTeto)/rendimento;
        }
    }
}