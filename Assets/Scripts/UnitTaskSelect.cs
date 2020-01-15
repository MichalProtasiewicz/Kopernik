using UnityEngine;
using UnityEngine.UI;

public class UnitTaskSelect : MonoBehaviour
{
    public string taskName;
    public bool done;
    public Sprite uncheckedSprite;
    public Sprite checkedSprite;
    public Image isCheckedSprite;

    void Start()
    {
        if (PlayerPrefs.GetInt(taskName) == 1)
            done = true;
        else
            done = false;

        if (done)
            isCheckedSprite.sprite = checkedSprite;
        else
            isCheckedSprite.sprite = uncheckedSprite;
    }
}
