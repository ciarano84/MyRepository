using UnityEngine;
using System.Collections;

public class Encounter : MonoBehaviour {

    public int frequency = 2;
    public float speed;
    public GameObject XPText;

    protected RPGGameManager manager;

    void Start() {
        XPText = manager.GetComponent<RPGGameManager>().XPText;
    }

    void Update()
    {
        //Moves the monster to the left.
        transform.Translate(Vector3.right * Time.deltaTime * -speed);
        //Cleans him up if he ends up wandering off screen.
        if (transform.position.x <= -10)
            Destroy(gameObject);
    }

    protected void Reward(string text, int xp) {
        //Get a reference to the XPText that is created, tell it how many points to show and ask it to clear itself up afterwards.
        Vector3 start = new Vector3(transform.position.x + 2, transform.position.y + 4, transform.position.z);
        GameObject XP = (GameObject)Instantiate(XPText, start, Quaternion.identity);
        if (xp == 0)
        {
            XP.GetComponent<TextMesh>().text = text;
        }
        else {
            XP.GetComponent<TextMesh>().text = xp + " XP";
        }
        Destroy(XP, 5);
    }
}
