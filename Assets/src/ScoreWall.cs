using UnityEngine;

namespace src
{
    public class ScoreWall : MonoBehaviour
    {
        private GameManager _game;
        private BallControl _ball;

        public void Start()
        {
            _game = GameObject.FindGameObjectWithTag("hud").GetComponent<GameManager>();
            _ball = GameObject.FindGameObjectWithTag("ball").GetComponent<BallControl>();
        }

        public void OnTriggerEnter2D(Collider2D hitInfo)
        {
            if (hitInfo.name != _ball.name) return;

            var wallName = transform.name;
            _game.AddScore(wallName);
            _ball.NewGame();
        }
    }
}