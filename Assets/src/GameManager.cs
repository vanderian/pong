using UnityEngine;

namespace src
{
    public class GameManager : MonoBehaviour
    {
        private static int _playerScoreLeft = 0;
        private static int _playerScoreRight = 0;

        public GUISkin layout;

        private GameObject _ball;

        public static void AddScore(string wall)
        {
            if (wall == "WallRight")
            {
                _playerScoreLeft++;
            }
            else
            {
                _playerScoreRight++;
            }
        }

        public void Start()
        {
            _ball = GameObject.FindGameObjectWithTag("ball");
        }

        public void OnGUI()
        {
            GUI.skin = layout;
            GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + _playerScoreLeft);
            GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + _playerScoreRight);

            if (_playerScoreLeft != 10 && _playerScoreRight != 10) return;

            var text = _playerScoreLeft == 10 ? "ONE" : "TWO";
            GUI.Label(new Rect(Screen.width / 2 - 225, 200, 2000, 1000), $"PLAYER {text} WINS");
            _ball.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
    }
}