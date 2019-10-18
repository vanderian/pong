using UnityEngine;
using UnityEngine.SceneManagement;

namespace src
{
    public class MainMenuController : MonoBehaviour
    {
        private GameObject _mainMenu;
        private GameObject _leaderBoard;

        public void Start()
        {
            _mainMenu = GameObject.Find("MainMenu");
            _leaderBoard = GameObject.Find("LeaderBoard");
            _leaderBoard.SetActive(false);
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
    }
}