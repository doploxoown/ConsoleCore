using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _nome;

        public Jogador1(string nome = "Thiago")
        {
            _nome = nome;
        }

        public string Chuta()
        {
            return $"{_nome} está correndo \n";
        }

        public string Corre()
        {
            return $"{_nome} está correndo \n";
        }

        public string Passe()
        {
            return $"{_nome} está correndo \n";
        }
    }
}