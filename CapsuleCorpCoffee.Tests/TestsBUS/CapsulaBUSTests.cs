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
    public class CapsulaBUSTests
    {
        [Fact]
        public void NaoDeveValidarCapsulaSemPreencherPropriedades()
        {
            CapsulaBUS sut = FactoryBUS.CreateCapsulaBUS();
            Capsula sutObjeto = new Capsula();

            Assert.False(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void NaoDeveValidarCapsulaSemDescricao()
        {
            CapsulaBUS sut = FactoryBUS.CreateCapsulaBUS();
            Capsula sutObjeto = new Capsula();
            sutObjeto.Forca = 7;

            Assert.False(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void NaoDeveValidarCapsulaSemForca()
        {
            CapsulaBUS sut = FactoryBUS.CreateCapsulaBUS();
            Capsula sutObjeto = new Capsula();
            sutObjeto.Descricao = "Café";

            Assert.False(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void NaoDeveValidarCapsulaComForcaMenorQueZero()
        {
            CapsulaBUS sut = FactoryBUS.CreateCapsulaBUS();
            Capsula sutObjeto = new Capsula();
            sutObjeto.Descricao = "Café";
            sutObjeto.Forca = -3;

            Assert.False(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void NaoDeveValidarCapsulaComForcaMaiorQueDez()
        {
            CapsulaBUS sut = FactoryBUS.CreateCapsulaBUS();
            Capsula sutObjeto = new Capsula();
            sutObjeto.Descricao = "Café";
            sutObjeto.Forca = 11;

            Assert.False(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void DeveValidarCapsulaComDescricaoEForca()
        {
            CapsulaBUS sut = FactoryBUS.CreateCapsulaBUS();
            Capsula sutObjeto = new Capsula();
            sutObjeto.Descricao = "Café";
            sutObjeto.Forca = 8;

            Assert.True(sut.ValidarCampos(sutObjeto));
        }
    }
}
