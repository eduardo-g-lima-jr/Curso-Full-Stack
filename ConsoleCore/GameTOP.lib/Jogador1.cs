using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _nome;

        public Jogador1(string nome = "Eduardo")
        {
            _nome = nome;
        }

        //Chutar
        public string Chutar()
        {
            return ($"{_nome} está chutando \n");
        }
        //Correr
        public string Correr()
        {
            return ($"{_nome} está correndo \n");
        }
        //Passar
        public string Passar()
        {
            return ($"{_nome} está passando \n");
        }
    }
}