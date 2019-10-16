using UnityEngine;

namespace src
{
    public class ScoreWall : MonoBehaviour
    {
        public void OnTriggerEnter2D(Collider2D hitInfo)
        {
            if (hitInfo.name != "Ball") return;
            
            var wallName = transform.name;
            GameManager.AddScore(wallName);
            hitInfo.gameObject.SendMessage("NewGame", 1.0f, SendMessageOptions.RequireReceiver);
        }
    }
}