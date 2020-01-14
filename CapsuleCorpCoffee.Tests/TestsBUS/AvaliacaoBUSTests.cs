using CapsuleCorpCoffeeBUS;
using CapsuleCorpCoffeeBUS.Classes;
using CapsuleCorpCoffeeDTO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CapsuleCorpCoffee.Tests.TestsBUS
{
    public class AvaliacaoBUSTests
    {
        [Fact]
        public void NaoDeveValidarAvaliacaoVazia()
        {
            AvaliacaoBUS sut = FactoryBUS.CreateAvaliacaoBUS();
            Avaliacao sutObjeto = new Avaliacao();

            Assert.False(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void NaoDeveValidarAvaliacaoSemReceita()
        {
            AvaliacaoBUS sut = FactoryBUS.CreateAvaliacaoBUS();
            Avaliacao sutObjeto = new Avaliacao();

            sutObjeto.Nota = 3;

            Assert.False(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void NaoDeveValidarAvaliacaoComNotaAbaixoDeUm()
        {
            AvaliacaoBUS sut = FactoryBUS.CreateAvaliacaoBUS();
            Avaliacao sutObjeto = new Avaliacao();

            sutObjeto.Receita = 1;
            sutObjeto.Nota = -5;

            Assert.False(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void NaoDeveValidarAvaliacaoComNotaAcimaDeCinco()
        {
            AvaliacaoBUS sut = FactoryBUS.CreateAvaliacaoBUS();
            Avaliacao sutObjeto = new Avaliacao();

            sutObjeto.Receita = 1;
            sutObjeto.Nota = 7;

            Assert.False(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void DeveValidarAvaliacaoComCamposObrigatorios()
        {
            AvaliacaoBUS sut = FactoryBUS.CreateAvaliacaoBUS();
            Avaliacao sutObjeto = new Avaliacao();

            sutObjeto.Receita = 1;
            sutObjeto.Nota = 3;

            Assert.True(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void DeveValidarAvaliacaoComTodosOsCampos()
        {
            AvaliacaoBUS sut = FactoryBUS.CreateAvaliacaoBUS();
            Avaliacao sutObjeto = new Avaliacao();

            sutObjeto.Receita = 1;
            sutObjeto.Nota = 3;
            sutObjeto.Usuario = "Luke Skywalker";
            sutObjeto.Comentario = "Do or do not. There is no try. - Yoda";

            Assert.True(sut.ValidarCampos(sutObjeto));
        }
    }
}
