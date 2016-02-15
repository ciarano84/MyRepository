using UnityEngine;
using System.Collections;

public class BedroomObjects : MonoBehaviour {

    public GameObject gamer;
    public new string name;
    public Vector3 target;

    void OnMouseDown()
    {
        if (GameManager.recieveInputs)
        {
            Movement.destination point;
            point.name = name;
            point.target = target;
            gamer.GetComponent<Movement>().MoveTo(point);
        }
    }

    void OnMouseOver()
    {
        if (GameManager.recieveInputs)
            GetComponent<SpriteRenderer>().enabled = true;
    }

    void OnMouseExit()
    {
        if (GameManager.recieveInputs)
            GetComponent<SpriteRenderer>().enabled = false;
    }
}
