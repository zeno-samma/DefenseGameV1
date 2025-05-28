using UnityEngine;

namespace MRX.DefenseGameV1
{
    public class Pref
    {
        public static int bestCore
        {
            set
            {
                int oldBestScore = PlayerPrefs.GetInt(Const.BEST_SCORE_PREF, 0);
                if (oldBestScore < value)
                    PlayerPrefs.SetInt(Const.BEST_SCORE_PREF, value);
            }
            get => PlayerPrefs.GetInt(Const.BEST_SCORE_PREF, 0);
        }
        public static int curPlayerId
        {
            set => PlayerPrefs.SetInt(Const.CUR_PLAYER_ID_PREF, value);
            get => PlayerPrefs.GetInt(Const.CUR_PLAYER_ID_PREF, 0);
        }
        public static int coins
        {
            set => PlayerPrefs.SetInt(Const.COIN_PREF, value);
            get => PlayerPrefs.GetInt(Const.COIN_PREF, 0);
        }
        public static float musicVol
        {
            set => PlayerPrefs.SetInt(Const.MUSIC_VOL_PREF, (int)value);
            get => PlayerPrefs.GetInt(Const.MUSIC_VOL_PREF, 0);
        }
        public static float soundVol
        {
            set => PlayerPrefs.SetInt(Const.SOUND_VOL_PREF, (int)value);
            get => PlayerPrefs.GetInt(Const.SOUND_VOL_PREF, 0);
        }
        public static void SetBool(string key, bool value)
        {
            if (value)
                PlayerPrefs.SetInt(key, 1);
            else
                PlayerPrefs.SetInt(key, 0);
        }
        public static bool GetBool(string key)
        {
            int check = PlayerPrefs.GetInt(key);
            if (check == 0)
                return false;
            else if(check == 1)
                return true;
            return false;
        }
    }

}