using System;
using UnityEngine;

namespace Game
{
    public class Estimator
    {
        private readonly Rigidbody2D _ball;
        private readonly float _height;

        public Estimator(Rigidbody2D ball, float height)
        {
            _ball = ball;
            _height = height;
        }

        public float EstimatePosition(float x)
        {
            var ballVelocity = _ball.velocity;
            var ballPosition = _ball.position;
            var sv = Math.Sign(ballVelocity.y);
            var h = _height / 2;


            var dx = ballPosition.x - x;
            var t = Math.Abs(dx / ballVelocity.x);
            var y = Math.Abs(ballVelocity.y * t);
            var yp = h + sv * ballPosition.y;
            var bounces = (int) ((y + yp) / _height);
            var reminder = (y + yp) % _height;
            var dy = bounces % 2 == 0 ? reminder : _height - reminder;
            var targetY = sv * (dy - h);

            return targetY;
        }

        public static void DebugRectangle(Vector2 position, float size, Color color)
        {
            Debug.DrawLine(position, new Vector3(position.x + size, position.y, 0), color);
            Debug.DrawLine(position, new Vector3(position.x, position.y - size, 0), color);
            Debug.DrawLine(new Vector3(position.x, position.y - size, 0), new Vector3(position.x + size, position.y - size, 0), color);
            Debug.DrawLine(new Vector3(position.x + size, position.y - size, 0), new Vector3(position.x + size, position.y, 0), color);
        }
    }
}