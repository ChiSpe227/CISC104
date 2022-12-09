using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PongTests
{
    // A Test behaves as an ordinary method
    [Test]
    public void PongTestsSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator PongTestsWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }

    /*
    public class ScoreTests
    {
        private Score _playerScore = new PlayerScore();

        [Test]
        public void ShouldScore2Points()
        {
            _playerScore.score = 2;

            _playerScore.ScorePoint(true);

            Assert.AreEqual(_playerScore.score, 2);
        }
    }
    */








    /*[UnityTest]
    public IEnumerator ShouldMovePaddleDown()
    {
        // increase timeScale to execute the test quickly
        Time.timeScale = 20f;

        (GameObject PlayerPaddle, _) = _handler.CreatePaddles();
        Paddle pm = left.GetComponent<Paddle>();

        // move paddle down
        float startY = left.transform.position.y;
        float time = 0f;
        while (time < 1)
        {
            pm.MoveDown();
            time += Time.fixedDeltaTime;
            yield return null;
        }

        Assert.Less(Player.transform.position.y, startY);

        // reset timeScale
        Time.timeScale = 1f;
    }
    */
}
