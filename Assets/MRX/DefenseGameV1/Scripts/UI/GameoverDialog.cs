using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MRX.DefenseGameV1.UI
{
    public class GameoverDialog : Dialog
    {
        public Text bestLabelText;
        public override void Show(bool show)
        {
            base.Show(show);
            bestLabelText.text = Pref.bestCore.ToString("0000");
        }
        public void Replay()
        {
            Close();
            SceneManager.LoadScene(Const.GAMEPLAY_SCENE);
        }
        public void QuitGame()
        {
            Application.Quit();
        }

    }
}

