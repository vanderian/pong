using UnityEngine;

namespace Game
{
    public class BallControl : MonoBehaviour
    {
        public float speed = 2;
        private Rigidbody2D _body;

        public void Start()
        {
            _body = GetComponent<Rigidbody2D>();
            Invoke(nameof(Init), 1);
        }

        public void OnCollisionEnter2D(Collision2D coll)
        {
            if (!coll.collider.CompareTag("Player")) return;

            var v = _body.velocity;
            _body.velocity = new Vector2(v.x, (v.y) + (coll.collider.attachedRigidbody.velocity.y / 2));
        }

        public void NewGame()
        {
            ResetBall();
            Invoke(nameof(Init), 2);
        }

        public void ResetBall()
        {
            _body.velocity = Vector2.zero;
            transform.position = Vector3.zero;
        }

        private void Init()
        {
            var direction = Random.Range(0, 2) < 1 ? 1 : -1;
            _body.velocity = speed * new Vector2(2 * direction, -1);
        }
    }
}