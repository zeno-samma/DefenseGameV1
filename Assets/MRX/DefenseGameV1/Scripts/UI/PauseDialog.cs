using UnityEngine;
using  UnityEngine.SceneManagement;

namespace MRX.DefenseGameV1.UI
{
    public class PauseDialog : Dialog
    {

        public override void Show(bool isShow)
        {
            Time.timeScale = 0f;
            base.Show(isShow);
        }
        public void ResumeGame()
        {
            Close();
            base.Show(false);
        }
        public void Replay()
        {
            Close();
            SceneManager.LoadScene(Const.GAMEPLAY_SCENE);
        }
        public override void Close()
        {
            Time.timeScale = 1f;
        }

    }

}

