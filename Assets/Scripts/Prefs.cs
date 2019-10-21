using UnityEngine;

namespace Menu
{
    public static class Prefs
    {
        private static readonly string ID_KEY = "pref_id";
        private static readonly string NAME_KEY = "pref_name";

        public static bool HasPlayerId()
        {
            return PlayerPrefs.HasKey(ID_KEY);
        }

        public static string GetPlayerId()
        {
            return PlayerPrefs.GetString(ID_KEY);
        }

        public static string GetPlayerName()
        {
            return PlayerPrefs.GetString(NAME_KEY);
        }

        public static void SetPlayerName(string name)
        {
            PlayerPrefs.SetString(NAME_KEY, name);
            PlayerPrefs.Save();
        }

        public static void OnLogin(string id, string name)
        {
            PlayerPrefs.SetString(ID_KEY, id);
            PlayerPrefs.SetString(NAME_KEY, name);
            PlayerPrefs.Save();
        }
    }
}