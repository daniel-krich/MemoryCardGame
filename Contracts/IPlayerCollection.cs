﻿using MemorizIt.Models;
using System.Collections.Generic;

namespace MemorizIt.Contracts
{
    public interface IPlayerCollection
    {
        int CurrentPlayerIndex { get; }
        List<PlayerModel> Players { get; set; }

        void InsertPlayer(string name);
        int NextPlayerTurn();
        PlayerModel PlayerWithHighestScore();
    }
}