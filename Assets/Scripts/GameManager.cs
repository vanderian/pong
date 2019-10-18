using System;
using Api;
using Client;
using Game;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int endScore = 10;

    private int _playerScoreLeft = 0;
    private int _playerScoreRight = 0;
    private readonly Guid _id = Guid.NewGuid();

    public GUISkin layout;

    private BallControl _ball;
    private AiControl _ai;
    private LeaderBoardApi _api;

    public void Start()
    {
        _ball = GameObject.FindGameObjectWithTag("ball").GetComponent<BallControl>();
        _ai = FindObjectOfType<AiControl>();
        _api = FindObjectOfType<LeaderBoardApi>();
    }

    public void OnGUI()
    {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + _playerScoreLeft);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + _playerScoreRight);

        if (_playerScoreLeft != endScore && _playerScoreRight != endScore) return;

        var text = _playerScoreLeft == endScore ? "ONE" : "TWO";
        GUI.Label(new Rect(Screen.width / 2 - 225, 200, 2000, 1000), $"PLAYER {text} WINS");

        _ball.ResetBall();

        Debug.Log("add score");
        var s = _api.GetClient().AddScore(new PlayerScore() {Id = _id.ToString(), Score = 10});
        Debug.Log(s);
    }

    public void AddScore(string wall)
    {
        if (wall == "WallRight")
        {
            _playerScoreLeft++;
            _ai.level++;
        }
        else
        {
            _playerScoreRight++;
            _ai.level--;
        }
    }
}