﻿using System;
using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var Jogo = new GameTOP.JogoFODA(new Jogador1(),
                                            new Jogador2());
            Jogo.IniciarJogo();
        }
    }

    
}
