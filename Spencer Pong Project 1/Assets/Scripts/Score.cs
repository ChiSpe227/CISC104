using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score
{
    private int _playerScore;
    private int _computerScore;

    public void AddPlayerScore(int scorevalue)
    {
        _playerScore += scorevalue;
    }
    public int getPlayerScore()
    {
        return _playerScore;
    }

    public void AddComputerScore(int scorevalue)
    {
        _computerScore += scorevalue;
    }
    public int getComputerScore()
    {
        return _computerScore;
    }
}
