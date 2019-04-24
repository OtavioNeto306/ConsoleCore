using GameTOP.Interface;
namespace GameTOP.lib

{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
           return "Pele estas Pateando \n";
        }

        public string Corre()
        {
           return "Pele estas Corriendo \n";
        }

        public string Passe()
        {
           return "Pele estas Passando \n";
        }
    }
}