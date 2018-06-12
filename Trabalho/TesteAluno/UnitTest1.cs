using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrabalhoAluno;

namespace TesteAluno
{
    [TestClass]
    public class UnitTest1
    { 
         
        [TestMethod]
        public void TesteIdadeTrue()
        {

            Aluno a1 = new Aluno();
            
            a1.Nome = "Felipe";
            a1.Sobrenome = "Vozgeral Çanca";
            a1.DataDeNAscimento = new DateTime(1990,04,01);

            Aluno a2 = new Aluno();
            a2.Nome = "Alin@";
            a2.Sobrenome = "Branca";
            a2.DataDeNAscimento = new DateTime(2020, 01, 01);

            Aluno a3 = new Aluno();
            a3.Nome = "Alfredo";
            a3.Sobrenome = "Sella III";
            a3.DataDeNAscimento = new DateTime(1986, 03, 12);

            Assert.IsTrue(a1.idade() > 0);

        } //ok

        [TestMethod]
        public void TesteNomeCompletoTrue()
        {

            Aluno a1 = new Aluno();

            a1.Nome = "Felipe";
            a1.Sobrenome = "Vozgeral Çanca";
            a1.DataDeNAscimento = new DateTime(1990, 04, 01);

            Aluno a2 = new Aluno();
            a2.Nome = "Alin@";
            a2.Sobrenome = "Branca";
            a2.DataDeNAscimento = new DateTime(2020, 01, 01);

            Aluno a3 = new Aluno();
            a3.Nome = "Alfredo";
            a3.Sobrenome = "Sella III";
            a3.DataDeNAscimento = new DateTime(1986, 03, 12);

            Assert.AreEqual(a3.NomeCompleto(), "Alfredo Sella III");
        } //ok

        [TestMethod]
        public void TesteValidaNomeTrue()
        {

            Aluno a1 = new Aluno();

            a1.Nome = "Felipe";
            a1.Sobrenome = "Vozgeral Çanca";
            a1.DataDeNAscimento = new DateTime(1990, 04, 01);

            Aluno a2 = new Aluno();
            a2.Nome = "Alin@";
            a2.Sobrenome = "Branca";
            a2.DataDeNAscimento = new DateTime(2020, 01, 01);

            Aluno a3 = new Aluno();
            a3.Nome = "Alfredo";
            a3.Sobrenome = "Sella III";
            a3.DataDeNAscimento = new DateTime(1986, 03, 12);

            Assert.AreEqual(a2.ValidaNome(), 2);

        }//ok

        [TestMethod]
        public void TesteErroValidacaoTrue()
        {

            Aluno a1 = new Aluno();

            a1.Nome = "Felipe";
            a1.Sobrenome = "Vozgeral Çanca";
            a1.DataDeNAscimento = new DateTime(1990, 04, 01);

            Aluno a2 = new Aluno();
            a2.Nome = "Alin@";
            a2.Sobrenome = "Branca";
            a2.DataDeNAscimento = new DateTime(2020, 01, 01);

            Aluno a3 = new Aluno();
            a3.Nome = "Alfredo";
            a3.Sobrenome = "Sella III";
            a3.DataDeNAscimento = new DateTime(1986, 03, 12);

            Assert.AreEqual(a1.ValidaNome(), 2);
        } //ok

        [TestMethod]
        public void TesteIdadeFalse()
        {

            Aluno a1 = new Aluno();

            a1.Nome = "Felipe";
            a1.Sobrenome = "Vozgeral Çanca";
            a1.DataDeNAscimento = new DateTime(1990, 04, 01);

            Aluno a2 = new Aluno();
            a2.Nome = "Alin@";
            a2.Sobrenome = "Branca";
            a2.DataDeNAscimento = new DateTime(2020, 01, 01);

            Aluno a3 = new Aluno();
            a3.Nome = "Alfredo";
            a3.Sobrenome = "Sella III";
            a3.DataDeNAscimento = new DateTime(1986, 03, 12);

            var data = new DateTime();
            a1.idade();
            var d = DateTime.Now;
            Assert.IsTrue(a1.idade() > d.Year);


        } //ok

        [TestMethod]
        public void TesteNomeCompletoFalse()
        {

            Aluno a1 = new Aluno();

            a1.Nome = "Felipe";
            a1.Sobrenome = "Vozgeral Çanca";
            a1.DataDeNAscimento = new DateTime(1990, 04, 01);

            Aluno a2 = new Aluno();
            a2.Nome = "Alin@";
            a2.Sobrenome = "Branca";
            a2.DataDeNAscimento = new DateTime(2020, 01, 01);

            Aluno a3 = new Aluno();
            a3.Nome = "Alfredo";
            a3.Sobrenome = "Sella III";
            a3.DataDeNAscimento = new DateTime(1986, 03, 12);

            Assert.AreEqual(a2.NomeCompleto(), "Aline Branca");

        } //ok

        [TestMethod]
        public void TesteValidaNomeFalse()
        {

            Aluno a1 = new Aluno();

            a1.Nome = "Felipe";
            a1.Sobrenome = "Vozgeral Çanca";
            a1.DataDeNAscimento = new DateTime(1990, 04, 01);

            Aluno a2 = new Aluno();
            a2.Nome = "Alin@";
            a2.Sobrenome = "Branca";
            a2.DataDeNAscimento = new DateTime(2020, 01, 01);

            Aluno a3 = new Aluno();
            a3.Nome = "Alfredo";
            a3.Sobrenome = "Sella III";
            a3.DataDeNAscimento = new DateTime(1986, 03, 12);

            Assert.AreEqual(a1.ValidaNome(), 1);
            

        } //ok

        [TestMethod]
        public void TesteErroValidacaoFalse()
        {

            Aluno a1 = new Aluno();

            a1.Nome = "Felipe";
            a1.Sobrenome = "Vozgeral Çanca";
            a1.DataDeNAscimento = new DateTime(1990, 04, 01);

            Aluno a2 = new Aluno();
            a2.Nome = "Alin@";
            a2.Sobrenome = "Branca";
            a2.DataDeNAscimento = new DateTime(2020, 01, 01);

            Aluno a3 = new Aluno();
            a3.Nome = "Alfredo";
            a3.Sobrenome = "Sella III";
            a3.DataDeNAscimento = new DateTime(1986, 03, 12);

            Assert.AreEqual(a1.ValidaNome(), 1);
            
        } //ok



    }



}
