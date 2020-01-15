using UnityEngine;
using UnityEngine.UI;

public class PlanetMenu : MonoBehaviour {

    public GameObject previousButton;
    public GameObject nextButton;
    public Text planetName;

    public GameObject planetModel;
    private Vector3 scaleMod = new Vector3(1.0f, 1.0f, 1.0f);

    private string[] planets = { "Sun", "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
    int i = -1;

    void Start () {
        planetName.text = " ";
    }

    public void ChangePlanet(string move)
    {
        if(i!=-1)
        {
            planetModel = GameObject.Find("Anchor/Sun(Clone)/" + planets[i] + "/" + planets[i]);
            planetModel.transform.localScale = planetModel.transform.localScale - scaleMod;
        }
        if (move == "next")
        {
            i++;
            if(i>8)
                i = 0;
        }
        if(move == "previous")
        {
            i--;
            if (i < 0)
                i = 8;
        }
        planetName.text = planets[i];

        planetModel = GameObject.Find("Anchor/Sun(Clone)/" + planets[i] + "/" + planets[i]);
        planetModel.transform.localScale = planetModel.transform.localScale + scaleMod;
    }
}
