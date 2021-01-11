using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "Patricia está Chutando \n";
        }

        public string Corre()
        {
            return "Patricia está Correndo \n";
        }

        public string Passe()
        {
            return "Patricia está Passando \n";
        }
    }
}