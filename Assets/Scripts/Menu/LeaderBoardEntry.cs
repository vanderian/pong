using Api;
using TMPro;
using UnityEngine;

namespace Menu
{
    public class LeaderBoardEntry : MonoBehaviour
    {
        public TextMeshProUGUI rank;
        public TextMeshProUGUI playerName;
        public TextMeshProUGUI score;

        public void SetRank(PlayerScore playerScore)
        {
            rank.text = $"{playerScore.Rank}";
            playerName.text = playerScore.Name;
            score.text = $"{playerScore.Score}";
        }
    }
}