using Api;
using Game;
using Menu;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int _playerScore = 0;
    private bool _lost = false;

    public GUISkin layout;

    private BallControl _ball;
    private AiControl _ai;
    private PongApi _api;

    public void Start()
    {
        _ball = GameObject.FindGameObjectWithTag("ball").GetComponent<BallControl>();
        _ai = FindObjectOfType<AiControl>();
        _api = FindObjectOfType<PongApi>();
    }

    public void OnGUI()
    {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2f - 12, 20, 100, 100), "" + _playerScore);

        if (!_lost) return;

        GUI.Label(new Rect(Screen.width / 2 - 300, 200, 2000, 1000), $"YOU LOST, YOUR SCORE IS {_playerScore}");

        if (GUI.Button(new Rect(Screen.width / 2 - 100, 350, 200, 50), "NEW GAME"))
        {
            _playerScore = 0;
            _lost = false;
            _ball.NewGame();
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 100, 425, 200, 50), "EXIT"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void AddScore(string wall)
    {
        if (wall == "WallRight")
        {
            Debug.Log("add score for player");
            var id = Prefs.GetPlayerId();
            var s = _api.GetClient().AddScore(new NewScore() {Id = id, Score = _playerScore});
            Debug.Log(s);
            _lost = true;
            _ball.ResetBall();
        }
        else
        {
            _playerScore++;
            _ai.IncreaseLevel();
            _ball.NewGame();
        }
    }
}