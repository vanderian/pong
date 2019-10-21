using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Game
{
    public class AiControl : MonoBehaviour
    {
        public float speed = 5;

        private float _level;
        private float _target;
        private Estimator _estimator;
        private Rigidbody2D _ball;
        private Rigidbody2D _body;
        private float _time;

        public void Start()
        {
            ResetLevel();
            _body = GetComponent<Rigidbody2D>();
            _ball = GameObject.FindGameObjectWithTag("ball").GetComponent<Rigidbody2D>();
            var top = GameObject.Find("WallTop").GetComponent<BoxCollider2D>();
            var btm = GameObject.Find("WallBottom").GetComponent<BoxCollider2D>();

            var height = top.transform.position.y + top.size.y / 2 - btm.transform.position.y + btm.size.y / 2 - _ball.GetComponent<CircleCollider2D>().radius;
            _estimator = new Estimator(_ball, height);
        }

        public void FixedUpdate()
        {
            if (_ball.velocity.x >= 0)
            {
                MoveToPoint(0);
                _time = 1000;
                return;
            }

            var x = transform.position.x;
            var y = _estimator.EstimatePosition(x);
            Estimator.DebugRectangle(new Vector2(x, y), 0.1f, Color.red);

            y = Error(y);
            Estimator.DebugRectangle(new Vector2(x, y), 0.1f, Color.green);

            _time += Time.fixedDeltaTime;
            if (_time > _level * 0.1)
            {
                _target = y;
                _time = 0;
            }

            ;

            MoveToPoint(_target);
        }

        public void ResetLevel()
        {
            _level = 10f;
        }

        public void IncreaseLevel()
        {
            _level -= 0.1f;
            _level = Mathf.Max(_level, 0);
        }

        private float Error(float y)
        {
            var x = transform.position.x;
            var w = Mathf.Abs(x * 2);
            var c = (_ball.position.x - x) / w;
            var error = _level * c * 2f;
            var newY = y + Random.Range(-error, error);
            return newY;
        }

        private void MoveToPoint(float target, float offset = 0.2f)
        {
            var y = _body.position.y;
            var direction = y < target - offset ? 1 : y > target + 0.2 ? -1 : 0;
            _body.velocity = new Vector2(0, direction * speed);
        }
    }
}