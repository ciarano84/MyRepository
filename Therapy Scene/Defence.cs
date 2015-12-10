using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Defence : MonoBehaviour {

    public GameObject gameManager;
    public Text text;
    public float speed = 0.02f;
    public float timeToClearBubble = 3;

    GameObject canvas;
    string[] stringArray = new string[4];

    void Start()
    {
        //Get a reference to the TherapyGameManager
        gameManager = GameObject.Find("TherapyGameManager");

        //populate the string array;
        stringArray[0] = "Whatever";
        stringArray[1] = "I'm FINE";
        stringArray[2] = "Can I go now?";
        stringArray[3] = "I see dead people!";

        string randomString = stringArray[Random.Range(0, 4)];
        canvas = GameObject.Find("Canvas"); //get a reference to the canvas
        transform.SetParent(canvas.transform, false); //Set the canvas as the parent so it appears as UI
        text.text = randomString;
        Invoke("DestroyAndTellGameManager", timeToClearBubble);
    }

    //Clears the bubble and tells the game manager to tell the therapist it's his turn to act.
    void DestroyAndTellGameManager() {
        gameManager.GetComponent<TherapyGameManager>().OverToTheTherapist();
        Destroy(gameObject);
    }
}
