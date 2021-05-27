using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TempoPassado.ConsoleApp;
namespace Testes
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        public void DeveRetornarUmaHoraAtras()
        {
            DateTime data = new DateTime(2021, 05, 26, 17, 00, 00);
            DataBase DataBase = new DataBase();

            Assert.AreEqual("uma hora atrás", DataBase.PegaData(data));
        }

        [TestMethod]
        public void DeveRetornarQuatorzeHorasETrêsMinutosAtras()
        {
            DateTime data = new DateTime(2021, 05, 26, 03, 57, 00);
            DataBase DataBase = new DataBase();

            Assert.AreEqual("quatorze horas e três minutos atrás", DataBase.PegaData(data));
        }

        [TestMethod]
        public void DeveRetornarQuatorzeHorasETrêsMinutosETrintaEDoisSegundosAtras()
        {
            DateTime data = new DateTime(2021, 05, 26, 04, 57, 28);
            DataBase DataBase = new DataBase();

            Assert.AreEqual("treze horas e dois minutos e trinta e dois segundos atrás", DataBase.PegaData(data));
        }

        [TestMethod]
        public void DeveRetornarDuasHorasECincoSegundos()
        {
            DateTime data = new DateTime(2021, 05, 26, 15, 59, 55);
            DataBase DataBase = new DataBase();

            Assert.AreEqual("duas horas e cinco segundos atrás", DataBase.PegaData(data));
        }

        [TestMethod]
        public void DeveRetornarUmaSemanaEDoisDiasAtras()
        {
            DateTime data = new DateTime(2021, 05, 17, 18, 00, 00);
            DataBase DataBase = new DataBase();

            Assert.AreEqual("uma semana e dois dias atrás", DataBase.PegaData(data));
        }

        [TestMethod]
        public void DeveRetornarUmDiaAtras()
        {
            DateTime data = new DateTime(2021, 05, 25, 12, 00, 00);
            DataBase DataBase = new DataBase();

            Assert.AreEqual("um dia atrás", DataBase.PegaData(data));
        }

        [TestMethod]
        public void DeveRetornarDoisMesesETresDiasAtras()
        {
            DateTime data = new DateTime(2021, 03, 23, 18, 00, 00);
            DataBase DataBase = new DataBase();

            Assert.AreEqual("dois meses e três dias atrás", DataBase.PegaData(data));
        }

        [TestMethod]
        public void DeveRetornarDoisAnosETresMesesEDoisDiaAtras()
        {
            DateTime data = new DateTime(2019, 02, 24, 18, 00, 00);
            DataBase DataBase = new DataBase();

            Assert.AreEqual("dois anos e três meses e dois dias atrás", DataBase.PegaData(data));
        }

        [TestMethod]
        public void DeveRetornarDoisAnosETresMesesEDuasSemanasEDoisDiaAtras()
        {
            DateTime data = new DateTime(2019, 02, 10, 18, 00, 00);
            DataBase DataBase = new DataBase();

            Assert.AreEqual("dois anos e três meses e duas semanas e dois dias atrás", DataBase.PegaData(data));
        }

        [TestMethod]
        public void DeveRetornarDoisAnosETresMesesEDuasSemanasEDoisDiaEQuatroHorasETrintaEDoisMinutosECinquentaCegundosAtras()
        {
            DateTime data = new DateTime(2019, 03, 10, 03, 28, 10);
            DataBase DataBase = new DataBase();

            Assert.AreEqual("dois anos e dois meses e duas semanas e dois dias e quatorze horas e trinta e um minutos e cinquenta segundos atrás", DataBase.PegaData(data));
        }

        [TestMethod]
        public void DeveRetornarDuasSemanasAtras()
        {
            DateTime data = new DateTime(2021, 05, 12, 18, 00, 00);
            DataBase DataBase = new DataBase();

            Assert.AreEqual("duas semanas atrás", DataBase.PegaData(data));
        }

        [TestMethod]
        public void DeveRetornarDuasSemanasAtrasEDoisDias()
        {
            DateTime data = new DateTime(2021, 05, 10, 18, 00, 00);
            DataBase DataBase = new DataBase();

            Assert.AreEqual("duas semanas e dois dias atrás", DataBase.PegaData(data));
        }
    }
}
