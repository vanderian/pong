using UnityEngine;

namespace Game
{
    public class ScoreWall : MonoBehaviour
    {
        private GameManager _game;

        public void Start()
        {
            _game = GameObject.FindGameObjectWithTag("hud").GetComponent<GameManager>();
        }

        public void OnTriggerEnter2D(Collider2D hitInfo)
        {
            if (hitInfo.name != "Ball") return;

            var wallName = transform.name;
            _game.AddScore(wallName);
        }
    }
}