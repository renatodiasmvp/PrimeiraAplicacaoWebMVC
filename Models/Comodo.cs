using System;

namespace PrimeiraAplicacaoMVC.Models
{
    public class Comodo
    {
        private Double _largura;
        public Double Largura 
        { 
            get { return _largura; } 
            set { _largura = value; }            
        }
        private Double _altura;
        public Double Altura 
        { 
            get { return _altura; } 
            set { _altura = value; }            
        }
        private Double _profundidade;
        public Double Profundidade 
        { 
            get { return _profundidade; } 
            set { _profundidade = value; }            
        }
    }
}