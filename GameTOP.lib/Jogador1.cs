
using GameTOP.Interface;

namespace GameTOP.lib
{
    
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome)
        {
            _Nome = nome;
        } 

        public string Chuta()
        {
              return "Otavio está Chutando \n";
        }

        public string Corre()
        {
              return "Otavio está Correndo \n";

        }

        public string Passe()
        {
             return "Otavio está passando \n";

        }

    }
}