using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Intervention : MonoBehaviour {

    public Text text;
    public float minWaitBetweenChar = 0.5f;
    public float maxWaitBetweenChar = 1.0f;

    GameObject therapyGameManager;
    GameObject canvas;
    GameObject gamer;
    char[] charArray;
    string[] stringArray = new string[4];
    int tapCount = 0;

    void Start () {
        gamer = GameObject.Find("Gamer");
        therapyGameManager = GameObject.Find("TherapyGameManager");

        //populate the string array;
        stringArray [0] = "Tell me about your sexual experiences.";
        stringArray[1] = "Do you ever have uncomfortable feelings about your mother?";
        stringArray[2] = "Have you come here simply to placate your father?";
        stringArray[3] = "What comes up for you when you consider the future?";

        string randomString = stringArray[Random.Range (0,4)];
        canvas = GameObject.Find("Canvas"); //get a reference to the canvas
        transform.SetParent(canvas.transform, false); //Set the canvas as the parent so it appears as UI
        charArray = randomString.ToCharArray(0, randomString.Length); //turn the string into an array of chars
        StartCoroutine ("PrintText");
    }

    IEnumerator PrintText() {
        foreach (char x in charArray)
        {
            text.text = (text.text + x); //while they haven't, keep printing the next letter to the speech bubble.
            TherapyGameManager.gamerResolve -= 1;
            therapyGameManager.GetComponent<TherapyGameManager>().updateResolve(); //Tell the gamemanager to display the resolves of both people.
            if (!therapyGameManager.GetComponent<TherapyGameManager>().gameActive)
                Destroy(gameObject);
            yield return new WaitForSeconds(Random.Range (minWaitBetweenChar,maxWaitBetweenChar));
        }
    }

    //The following is triggered by an event trigger on the intervention in the editor. It simply counts how many taps on the object. 
    public void TapCounter() {
        tapCount++;
        if (tapCount >= (Random.Range(3, 6))) //check to see if the player has tapped enough to defened against the intervention.
        {
            Destroy(gameObject);
            gamer.GetComponent<Defend>().DefendYourself();
        }
    } 
}
