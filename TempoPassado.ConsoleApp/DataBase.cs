using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempoPassado.ConsoleApp
{
    public class DataBase
    {
        public string PegaData(DateTime data)
        {
            DateTime dataPassada = new DateTime(2021, 05, 26, 18, 00, 00);

            string tempoPassado = "";

            if (data > dataPassada)
                tempoPassado = "Data inválida, não é possível datas futuras!";
            else
            {
                Converte a = new Converte();
                tempoPassado += a.Converter(data, dataPassada) + "atrás";
            }

            return tempoPassado;
        }
    }
}
