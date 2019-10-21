using System.Collections.Generic;
using System.Threading.Tasks;
using Api;
using Google.Protobuf.WellKnownTypes;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu
{
    public class MainMenuController : MonoBehaviour
    {
        public LeaderBoardEntry leaderBoardEntryPrefab;

        private GameObject _mainMenu;
        private GameObject _leaderBoard;
        private GameObject _leaderBoardList;
        private List<LeaderBoardEntry> _leaderBoardEntries = new List<LeaderBoardEntry>();
        private TMP_InputField _nameInput;
        private PongApi _api;

        public async void Start()
        {
            _api = FindObjectOfType<PongApi>();
            _mainMenu = GameObject.Find("MainMenu");
            _leaderBoard = GameObject.Find("LeaderBoard");
            _leaderBoardList = GameObject.Find("LeaderBoardList");
            _nameInput = GameObject.Find("InputName").GetComponent<TMP_InputField>();
            _leaderBoard.SetActive(false);
            CreateList();
            await Login();
        }

        public void StartGame()
        {
            SceneManager.LoadScene("GameScene");
        }

        public void LeaderBoard()
        {
            _mainMenu.SetActive(false);
            _leaderBoard.SetActive(true);
            PopulateList();
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

        public async void UpdateName()
        {
            var n = _nameInput.text;
            await _api.GetClient().SetNameAsync(new NewPlayerName() {Id = Prefs.GetPlayerId(), Name = n});
            Prefs.SetPlayerName(n);
        }

        private void CreateList()
        {
            for (var i = 0; i < 10; i++)
            {
                var item = Instantiate(leaderBoardEntryPrefab, _leaderBoardList.transform);
                _leaderBoardEntries.Add(item);
            }
        }

        private async Task Login()
        {
//            for testing
            PlayerPrefs.DeleteAll();

            var player = Prefs.GetPlayerName();
            if (!Prefs.HasPlayerId())
            {
                var id = await _api.GetClient().LoginAsync(new Empty());
                player = GenerateName();
                await _api.GetClient().SetNameAsync(new NewPlayerName() {Id = id.Id, Name = player});
                Debug.Log($"logged in {id}, {player}");
                Prefs.OnLogin(id.Id, player);
            }

            _nameInput.text = player;
        }

        private void PopulateList()
        {
            var scores = _api.GetClient().GetScores(new Empty());
            for (int i = 0; i < scores.Scores.Count; i++)
            {
                _leaderBoardEntries[i].SetRank(scores.Scores[i]);
                Debug.Log($"LB entry {scores.Scores[i]}");
            }
        }

        private string GenerateName()
        {
            var fnames = (Resources.Load("fname") as TextAsset).text.Split('\n');
            var lnames = (Resources.Load("lname") as TextAsset).text.Split('\n');

            return fnames[Random.Range(0, fnames.Length - 1)].Trim() + " " + lnames[Random.Range(0, lnames.Length - 1)].Trim();
        }
    }
}