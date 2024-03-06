using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTreinamento.Models
{
    public abstract class Telefone
    {

        public string Numero { get; set; }
        public string Uf {  get; set; }

        public string Ddd { get; set; }

        protected bool TemDdd { get; set;}

        protected bool TemFormatacao { get; set; }

        protected GerarDDD _buscaDdd = new();

        public abstract string CriaNumero();
        public abstract string Formata(bool temFormatacao, bool temDdd);

        public string CriaDdd(string uf)
        {
            return _buscaDdd.GerarPorUF(uf);
        }

        public string CriaDdd()
        {
            return _buscaDdd.GerarDddBrasil();
        }
    }
}
