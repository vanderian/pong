using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu
{
    public class MainMenuController : MonoBehaviour
    {
        public LeaderBoardEntry LeaderBoardEntryPrefab;

        private GameObject _mainMenu;
        private GameObject _leaderBoard;
        private GameObject _leaderBoardList;
        private List<LeaderBoardEntry> _leaderBoardEntries = new List<LeaderBoardEntry>();

        public void Start()
        {
            _mainMenu = GameObject.Find("MainMenu");
            _leaderBoard = GameObject.Find("LeaderBoard");
            _leaderBoardList = GameObject.Find("LeaderBoardList");
            _leaderBoard.SetActive(false);
            CreateList();
        }

        public void StartGame()
        {
            SceneManager.LoadScene("GameScene");
        }

        public void LeaderBoard()
        {
            _mainMenu.SetActive(false);
            _leaderBoard.SetActive(true);
        }

        public void Back()
        {
            _leaderBoard.SetActive(false);
            _mainMenu.SetActive(true);
        }

        public void Exit()
        {
            Application.Quit();
        }

        private void CreateList()
        {
            for (var i = 0; i < 10; i++)
            {
                var item = Instantiate(LeaderBoardEntryPrefab, _leaderBoardList.transform);
                item.rank.text = $"{i + 1}";
                _leaderBoardEntries.Add(item);
            }
        }
    }
}