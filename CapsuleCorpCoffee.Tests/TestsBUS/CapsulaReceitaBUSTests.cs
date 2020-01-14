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
    public class CapsulaReceitaBUSTests
    {
        [Fact]
        public void NaoDeveValidarObjetoSemPreencherPropriedades()
        {
            CapsulaReceitaBUS sut = FactoryBUS.CreateCapsulaReceitaBUS();
            CapsulaReceita sutObjeto = new CapsulaReceita();

            Assert.False(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void NaoDeveValidarCapsulaMenorIgualAZero()
        {
            CapsulaReceitaBUS sut = FactoryBUS.CreateCapsulaReceitaBUS();
            CapsulaReceita sutObjeto = new CapsulaReceita();

            sutObjeto.Quantidade = 1;
            sutObjeto.Capsula = 0;

            Assert.False(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void NaoDeveValidarQuantidadeMenorIgualAZero()
        {
            CapsulaReceitaBUS sut = FactoryBUS.CreateCapsulaReceitaBUS();
            CapsulaReceita sutObjeto = new CapsulaReceita();

            sutObjeto.Quantidade = -1;
            sutObjeto.Capsula = 1;

            Assert.False(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void DeveValidarCapsulaEQuantidadeMaiorQueZero()
        {
            CapsulaReceitaBUS sut = FactoryBUS.CreateCapsulaReceitaBUS();
            CapsulaReceita sutObjeto = new CapsulaReceita();

            sutObjeto.Quantidade = 4;
            sutObjeto.Capsula = 2;

            Assert.True(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void DeveValidarPropriedadesPreenchidas()
        {
            CapsulaReceitaBUS sut = FactoryBUS.CreateCapsulaReceitaBUS();
            CapsulaReceita sutObjeto = new CapsulaReceita();

            sutObjeto.Quantidade = 4;
            sutObjeto.Capsula = 2;
            sutObjeto.Receita = 7;

            Assert.True(sut.ValidarCampos(sutObjeto));
        }
    }
}
