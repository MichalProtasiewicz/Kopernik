using UnityEngine;

public class RotatePowVisController : MonoBehaviour
{
    private bool rotated;
    public string name;
    public GameObject anchor;

    void Start()
    {
        rotated = false;
    }

    void Update()
    {
        anchor = GameObject.Find("Anchor/"+ name +"(Clone)");

        if (!rotated && anchor)
        {
            anchor.transform.rotation = new Quaternion(0, 0, 0, 0);
            rotated = true;
        }
    }
}
