using UnityEngine;

public class TurnPlanets : MonoBehaviour {

    public float speed;

    void Update()
    {
        transform.Rotate(transform.up * Time.deltaTime * speed);
	}
}
