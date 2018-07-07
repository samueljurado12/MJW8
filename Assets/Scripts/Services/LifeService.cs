﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeService {

    public int player1Life, player2Life;

    public LifeService() {
        player1Life = 3; //TODO: Use settings 
        player2Life = 3; //TODO: Use settings
    }

    static LifeService instance;

    internal static LifeService getInstance()
    {
        if (instance == null)
        {
            instance = new LifeService();
        }
        return instance;
    }

    public void player1GainsLife() {
        player1Life++;
    }

    public void player2GainsLife()
    {
        player2Life++;
    }

    public bool player1LosesLife()
    {
        bool playerHasZeroLives = false;
        player1Life--;
        if (player1Life == 0) {
            playerHasZeroLives = true;
        }
        return playerHasZeroLives;
    }

    public bool player2LosesLife()
    {
        bool playerHasZeroLives = false;
        player2Life--;
        if (player2Life == 0)
        {
            playerHasZeroLives = true;
        }
        return playerHasZeroLives;
    }
}