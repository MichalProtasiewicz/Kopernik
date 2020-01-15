using UnityEngine;
using UnityEngine.UI;

public class UnitSceneController : MonoBehaviour
{
    public string unitName;
    public UnitTaskSelect[] tasks;
    private bool allDone;
    public Button completeUnitBtn;

    void Start()
    {
        allDone = true;
        completeUnitBtn.interactable = false;

        for (int i = 0; i < tasks.Length; i++)
        {
            string taskName = tasks[i].taskName;
            if (PlayerPrefs.GetInt(taskName) == 0)
                allDone = false;
        }
        if (allDone)
        {
            completeUnitBtn.interactable = true;
            PlayerPrefs.SetInt(unitName, 1);
        }
    }
}
