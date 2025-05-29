using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MRX.DefenseGameV1.UI
{
    public class GUIController : MonoBehaviour
    {
        public GameObject homeGui;
        public GameObject gameGui;

        public Dialog gameoverDialog;
        public Text mainCoinTxt;
        public Text gameplayerCoinTxt;

        void Start()
        {

        }

        public void ShowGameGUI(bool isShow)
        {
            if (gameGui)
            {
                gameGui.SetActive(isShow);
            }
            if (homeGui)
            {
                homeGui.SetActive(!isShow);
            }

        }
        public void UpdateMainCoin()
        {
            if (mainCoinTxt)
            {
                mainCoinTxt.text = Pref.coins.ToString();
            }
        }
        public void UpdateGamePlayerCoin()
        {
            if (gameplayerCoinTxt)
            {
                gameplayerCoinTxt.text = Pref.coins.ToString();
            }
        }
        
    }

}
