using CapsuleCorpCoffeeBUS.Classes;

namespace CapsuleCorpCoffeeBUS
{
    public static class FactoryBUS
    {
        public static CapsulaBUS CreateCapsulaBUS()
        {
            return new CapsulaBUS();
        }

        public static EstoqueBUS CreateEstoqueBUS()
        {
            return new EstoqueBUS();
        }

        public static ReceitaBUS CreateReceitaBUS()
        {
            return new ReceitaBUS();
        }

        public static CapsulaReceitaBUS CreateCapsulaReceitaBUS()
        {
            return new CapsulaReceitaBUS();
        }

        public static AvaliacaoBUS CreateAvaliacaoBUS()
        {
            return new AvaliacaoBUS();
        }
    }
}
