using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : IJogador
    {

        public string Chuta()
        {
            return "Roberto Carlos está chutando \n";
        }

        public string Corre()
        {
            return "Roberto Carlos está correndo \n";
        }

        public string Passe()
        {
            return "Roberto Carlos está passando \n";
        }
    }
}