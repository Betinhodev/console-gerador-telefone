using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTreinamento.Models
{
    public class TelefoneBuilder
    {
        public string Tipo { get; private set; }
        public bool TemFormatacao { get; private set; }

        public bool TemDdd { get; private set; }

        public string Uf { get; private set; }

        public string Constroi()
        {
            ExercicioTreinamento.Models.ModeloNumero
                template = new();
            return template.GeraTelefone(Tipo, TemFormatacao, TemDdd, Uf);
        }

        public TelefoneBuilder NumeroAleatorio()
        {
            this.Tipo = "";
            return this;
        }
        public TelefoneBuilder NumeroFixo()
        {
            this.Tipo = "FIXO";
            return this;
        }
        public TelefoneBuilder NumeroCelular()
        {
            this.Tipo = "CELULAR";
            return this;
        }
        public TelefoneBuilder ComFormatacao()
        {
            this.TemFormatacao = true;
            return this;
        }
        public TelefoneBuilder SemFormatacao()
        {
            this.TemFormatacao = false;
            return this;
        }

        public TelefoneBuilder ComDddAleatorio()
        {
            this.TemDdd = true;
            this.Uf = "";
            return this;
        }

        public TelefoneBuilder DddPorUF(string uf)
        {
            this.TemDdd = true;
            this.Uf = uf;
            return this;
        }
    }
}
