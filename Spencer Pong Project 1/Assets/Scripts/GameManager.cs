using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Text playerScoreText;
    public Text computerScoreText;
    
    private int _computerScore;
    private Score gameScore;

    public void PlayerScores()
    {

        gameScore.AddPlayerScore(2);
        Debug.Log(gameScore.getPlayerScore());
        this.playerScoreText.text = gameScore.getPlayerScore().ToString();
        ResetRound();
    }

    public void ComputerScores()
    {
        _computerScore++;
        Debug.Log(_computerScore);
        this.computerScoreText.text = _computerScore.ToString();
        ResetRound();
    }
    private void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}
