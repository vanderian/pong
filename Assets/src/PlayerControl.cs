using UnityEngine;

namespace src
{
    public class PlayerControl : MonoBehaviour
    {
        public float speed = 10.0f;
        private Rigidbody2D _body;

        public void Start()
        {
            _body = GetComponent<Rigidbody2D>();
        }

        public void FixedUpdate()
        {
            var direction = Input.GetAxisRaw("Vertical");
            _body.velocity = new Vector2(0, speed * direction);
        }
    }
}