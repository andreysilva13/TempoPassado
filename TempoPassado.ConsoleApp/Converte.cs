using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempoPassado.ConsoleApp
{
    public class Converte : DatasEmString
    {
        DatasEmString datas;
        public string Converter(DateTime data, DateTime dataPassada)
        {
            datas = new DatasEmString();

            string strDataPassada = "";

            int dias = dataPassada.Day - data.Day;
            int meses = dataPassada.Month - data.Month;
            int anos = dataPassada.Year - data.Year;
            int qtdSemanas = 0;
            bool dia = false, semana = false, mes = false, ano = false, hora = false, minuto = false;

            int horas = dataPassada.Hour - data.Hour;
            int minutos = Math.Abs(dataPassada.Minute - data.Minute);
            int segundos = Math.Abs(dataPassada.Second - data.Second);

            int auxSegundosDataPassada = dataPassada.Second;
            if ((auxSegundosDataPassada + data.Second) > 60 || (auxSegundosDataPassada + data.Second) == 0)
                minutos--;

            int auxMinutosDataPassada = dataPassada.Minute;
            if (auxMinutosDataPassada < data.Minute)
                horas--;

            if (anos > 0)
            {
                if (anos == 1)
                    strDataPassada += "um ano ";
                else
                    strDataPassada += datas.DiaMesAnoETempo(anos) + " anos ";
                ano = true;
            }

            if (meses > 0)
            {
                if (ano)
                    strDataPassada += "e ";
                if (meses == 1)
                    strDataPassada += "um mês ";
                else
                    strDataPassada += datas.DiaMesAnoETempo(meses) + " meses ";
                mes = true;
            }

            if (dias > 0)
            {
                int diasSemanas = 0;
                if (mes || ano)
                    strDataPassada += "e ";

                if (dias == 1)
                    return strDataPassada += "um dia ";
                else if (dias > 7)
                {
                    semana = true;

                    qtdSemanas = Convert.ToInt32(dias / 7);
                    diasSemanas = qtdSemanas * 7;
                    dias = dias - diasSemanas;

                    if (qtdSemanas == 1)
                        strDataPassada += datas.SemanaHora(qtdSemanas) + " semana e ";
                    else
                    {
                        if (dias != 0)
                            strDataPassada += datas.SemanaHora(qtdSemanas) + " semanas e ";
                        else
                            return strDataPassada += datas.SemanaHora(qtdSemanas) + " semanas ";
                    }
                }
                if (semana)
                {
                    strDataPassada += datas.DiaMesAnoETempo(dias) + " dias ";
                }
                else
                    strDataPassada += datas.DiaMesAnoETempo(dias) + " dias ";

                dia = true;
            }

            if (horas != 0 || minutos > 0 || segundos != 0)
            {
                if ((ano || mes || dia) && (horas != 0 || minutos != 0 || segundos != 0))
                    strDataPassada += "e ";

                if (horas > 0)
                {
                    if (horas == 1 || horas == 2)
                    {
                        switch (horas)
                        {
                            case 1: strDataPassada += datas.SemanaHora(horas) + " hora "; break;
                            case 2: strDataPassada += datas.SemanaHora(horas) + " horas "; break;
                            default: break;
                        }
                    }
                    else if (horas > 19)
                        strDataPassada += datas.MinutoESegundo(horas) + " hora ";
                    else
                        strDataPassada += datas.DiaMesAnoETempo(horas) + " horas ";

                    hora = true;
                }
                int segundosDoMinuto = 60 - segundos;
                if (minutos > 0 && minutos < 59)
                {
                    if (dataPassada.Second == 0 && data.Minute > 59)
                        minutos++;

                    if ((data.Second + segundosDoMinuto) >= 60)
                        minutos++;

                    if (hora)
                        strDataPassada += "e ";

                    minutos = 60 - minutos;

                    if (minutos < 20)
                        strDataPassada += datas.DiaMesAnoETempo(minutos) + " minutos ";
                    else
                        strDataPassada += datas.MinutoESegundo(minutos) + " minutos ";

                    minuto = true;
                }

                if (segundos > 0 && segundos < 59)
                {
                    if (hora || minuto)
                        strDataPassada += "e ";

                    if (segundosDoMinuto < 20)
                        strDataPassada += datas.DiaMesAnoETempo(segundosDoMinuto) + " segundos ";
                    else
                        strDataPassada += datas.MinutoESegundo(segundosDoMinuto) + " segundos ";
                }
            }
            return strDataPassada;
        }
    }
}
