﻿using DesignPatterns.Adapter.Libs;

namespace DesignPatterns.Adapter.Adapters
{
    public class Mp3PlayerAdapter : IPlayer
    {
        public void Play(string file)
        {
            Mp3Player mp3Player = new(file);
            mp3Player.Run();
        }
    }
}
