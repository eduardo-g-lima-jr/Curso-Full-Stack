using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chutar()
        {
            return "Maradona esta chutando";
        }

        public string Correr()
        {
            return "Maradona esta correndo";
        }

        public string Passar()
        {
            return "Maradona esta passando";
        }
    }
}