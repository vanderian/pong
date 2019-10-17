using UnityEngine;

namespace src
{
    public class GameManager : MonoBehaviour
    {
        private int _playerScoreLeft = 0;
        private int _playerScoreRight = 0;

        public GUISkin layout;

        private BallControl _ball;
        private AiControl _ai;

        public void Start()
        {
            _ball = GameObject.FindGameObjectWithTag("ball").GetComponent<BallControl>();
            _ai = FindObjectOfType<AiControl>();
        }

        public void OnGUI()
        {
            GUI.skin = layout;
            GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + _playerScoreLeft);
            GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + _playerScoreRight);
            GUI.Label(new Rect(Screen.width / 2 + 150 + 12, Screen.height - 100, 100, 100), "" + _ai.level);

            if (_playerScoreLeft != 10 && _playerScoreRight != 10) return;

            var text = _playerScoreLeft == 10 ? "ONE" : "TWO";
            GUI.Label(new Rect(Screen.width / 2 - 225, 200, 2000, 1000), $"PLAYER {text} WINS");

            _ball.ResetBall();
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
}