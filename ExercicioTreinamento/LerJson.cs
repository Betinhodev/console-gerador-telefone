using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using ExercicioTreinamento.Serialization;

namespace ExercicioTreinamento
{
    public static class LerJson
    {
        public static List<DDDPorUF> LerJsonDDDPorUF()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"dddsPorUF.json");
            var dddsPorUF = JsonConvert.DeserializeObject<List<DDDPorUF>>(json);

            return dddsPorUF;
        }

        public static DDDBrasil LerJsonDDDBrasil()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"dddsBrasil.json");
            var dddsBrasil = JsonConvert.DeserializeObject<DDDBrasil>(json);

            return dddsBrasil;
        }
    }
}