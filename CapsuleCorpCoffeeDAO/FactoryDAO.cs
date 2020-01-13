using CapsuleCorpCoffeeDAO.Classes;

namespace CapsuleCorpCoffeeDAO
{
    public static class FactoryDAO
    {
        public static CapsulaDAO CreateCapsulaDAO()
        {
            return new CapsulaDAO();
        }

        public static EstoqueDAO CreateEstoqueDAO()
        {
            return new EstoqueDAO();
        }

        public static ReceitaDAO CreateReceitaDAO()
        {
            return new ReceitaDAO();
        }

        public static CapsulaReceitaDAO CreateCapsulaReceitaDAO()
        {
            return new CapsulaReceitaDAO();
        }

        public static AvaliacaoDAO CreateAvaliacaoDAO()
        {
            return new AvaliacaoDAO();
        }
    }
}
