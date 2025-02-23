﻿namespace Lab_2;

public static class Factory
{
    public static Game CreateGame(GameAccount player1, GameAccount player2, int index, int rating)
    {
        if (index == 2)
        {
            return new TrainingGame(player1, player2);
        } else if (index == 3)
        {
            return new AllOrNothingGame(player1, player2);
        }
        return new DefaultGame(player1, player2, rating);
    }
}