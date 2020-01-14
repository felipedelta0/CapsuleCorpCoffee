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
    public class ReceitaBUSTests
    {
        [Fact]
        public void NaoDeveValidarObjetoSemPreencherPropriedades()
        {
            ReceitaBUS sut = FactoryBUS.CreateReceitaBUS();
            Receita sutObjeto = new Receita();

            Assert.False(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void NaoDeveValidarSemDescricao()
        {
            ReceitaBUS sut = FactoryBUS.CreateReceitaBUS();
            Receita sutObjeto = new Receita();

            sutObjeto.Descricao = "";

            Assert.False(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void DeveValidarComDescricao()
        {
            ReceitaBUS sut = FactoryBUS.CreateReceitaBUS();
            Receita sutObjeto = new Receita();

            sutObjeto.Descricao = "Receita de Toddy";

            Assert.True(sut.ValidarCampos(sutObjeto));
        }

        [Fact]
        public void DeveValidarComListaVaziaEDescricao()
        {
            ReceitaBUS sut = FactoryBUS.CreateReceitaBUS();
            Receita sutObjeto = new Receita();

            sutObjeto.Descricao = "Receita de Café";
            sutObjeto.Items = new List<CapsulaReceita>();

            Assert.True(sut.ValidarCampos(sutObjeto));
        }
    }
}
