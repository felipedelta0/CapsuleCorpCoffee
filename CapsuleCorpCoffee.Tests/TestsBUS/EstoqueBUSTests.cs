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
    public class EstoqueBUSTests
    {
        [Fact]
        public void NaoDeveValidarEstoqueSemPreencherPropriedades()
        {
            EstoqueBUS sut = FactoryBUS.CreateEstoqueBUS();
            Estoque sutObjeto = new Estoque();

            Assert.False(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void NaoDeveValidarSeAValidadeForAnteriorADataAtual()
        {
            EstoqueBUS sut = FactoryBUS.CreateEstoqueBUS();
            Estoque sutObjeto = new Estoque();

            sutObjeto.Quantidade = 1;
            sutObjeto.Validade = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 1);

            Assert.False(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void NaoDeveValidarSeAQuantidadeForMenorQueUm()
        {
            EstoqueBUS sut = FactoryBUS.CreateEstoqueBUS();
            Estoque sutObjeto = new Estoque();

            sutObjeto.Quantidade = -1;
            sutObjeto.Validade = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            Assert.False(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void DeveValidarSeQuantidadeForMaiorQueUmEValidadeDeHoje()
        {
            EstoqueBUS sut = FactoryBUS.CreateEstoqueBUS();
            Estoque sutObjeto = new Estoque();

            sutObjeto.Quantidade = 42;
            sutObjeto.Validade = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            Assert.True(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void DeveValidarSeQuantidadeForMaiorQueUmEValidadeSuperiorAHoje()
        {
            EstoqueBUS sut = FactoryBUS.CreateEstoqueBUS();
            Estoque sutObjeto = new Estoque();

            sutObjeto.Quantidade = 1;
            sutObjeto.Validade = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);

            Assert.True(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void DeveValidarSeEstiverComPropriedadesPreenchidas()
        {
            EstoqueBUS sut = FactoryBUS.CreateEstoqueBUS();
            Estoque sutObjeto = new Estoque();

            sutObjeto.Quantidade = 1;
            sutObjeto.Validade = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            sutObjeto.Capsula = 13;

            Assert.True(sut.ValidarCampos(sutObjeto));
        }
    }
}
