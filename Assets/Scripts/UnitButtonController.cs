using UnityEngine;
using UnityEngine.UI;

public class UnitButtonController : MonoBehaviour
{
    public string previousUnitName;
    public GameObject accessSprite;
    public Button button;

    void Start()
    {
        button.interactable = false;

        if (PlayerPrefs.GetInt(previousUnitName) == 1)
        {
            accessSprite.SetActive(false);
            button.interactable = true;
        }
    }
}
