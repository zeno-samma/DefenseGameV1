using UnityEngine;
using Unity.UI;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public Text titleText;
    public Text contentText;

    public virtual void Show(bool show)
    {
        gameObject.SetActive(show);
    }
    public virtual void SetTitle(string title, string content)
    {
        if (titleText != null)
        {
            titleText.text = title;
        }
        if (contentText != null && content != null)
        {
            contentText.text = content;
        }
    }
    public virtual void UpdateDialog(string title, string content)
    {
        SetTitle(title, content);
        Show(true);
    }

    public virtual void Close()
    {
        Show(false);
    }
}
