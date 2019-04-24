using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
           return "Maradona estas Pateando \n";
        }

        public string Corre()
        {
           return "Maradona estas Corriendo \n";
        }

        public string Passe()
        {
           return "Maradona estas Passando \n";
        }
    }
}