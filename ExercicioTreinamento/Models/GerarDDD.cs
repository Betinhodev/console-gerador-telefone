using ExercicioTreinamento.Serialization;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;

namespace ExercicioTreinamento.Models
{
    public class GerarDDD
    {
        public string GerarPorUF(string uf)
        {

            var ddds = BuscarPorUF(uf.ToUpper());

            if (ddds.Count == 1)
                return ddds[0];

            Random random = new Random();
            int sortIndex = random.Next(0, ddds.Count);
            return ddds[sortIndex];
        }

        private readonly List<DDDPorUF> _dddPorEstado = LerJson.LerJsonDDDPorUF();
        private List<string> BuscarPorUF(string uf)
        {

            for (int i = 0; i < _dddPorEstado.Count; i++)
            {
                if (_dddPorEstado[i].Sigla.Equals(uf))
                    return _dddPorEstado[i].Ddds;
            }

            return null;
        }

        private readonly DDDBrasil _dddsDoBrasil = LerJson.LerJsonDDDBrasil();
        public string GerarDddBrasil()
        {
            Random random = new Random();
            var indexRandom = random.Next(0, _dddsDoBrasil.Ddds.Count);
            return _dddsDoBrasil.Ddds[indexRandom];
        }
    }
}
