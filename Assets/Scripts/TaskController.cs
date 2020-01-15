using UnityEngine;
using UnityEngine.UI;

public class TaskController : MonoBehaviour
{
    public string taskName;
    public Text alert;
    public Button completeButton;
    public Button[] answerButtons;

    void Start()
    {
        alert.text = "";
        completeButton.interactable = false;
        for (int i = 0; i < answerButtons.GetLength(0); i++)
        {
            answerButtons[i].interactable = true;
        }
    }

    public void GoodAnswer()
    {
        alert.text = "Dobrze!";
        alert.color = Color.green;
        completeButton.interactable = true;
        for(int i = 0; i < answerButtons.GetLength(0); i++)
        {
            answerButtons[i].interactable = false;
        }
        PlayerPrefs.SetInt(taskName, 1);
    }

    public void BadAnswer()
    {
        alert.text = "Źle!";
        alert.color = Color.red;
    }
}
