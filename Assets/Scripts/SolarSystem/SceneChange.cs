using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

    public string sceneToChange;

	void Update ()
    {
        OnTouchUp();
	}

    public void OnMouseUp()
    {
        SceneManager.LoadScene(sceneToChange);
    }

    public void OnTouchUp()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;

            if(touchPosition == transform.position)
            {
                SceneManager.LoadScene(sceneToChange);
            }
        }
    }

}
