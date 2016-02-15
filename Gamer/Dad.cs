using UnityEngine;
using System.Collections;

public class Dad : MonoBehaviour {

    public GameManager gameManager;
    public GameObject speechBubble;
    public AnimationClip stormIn;
    public AnimationClip stormOut;

    void OnEnable()
    {
        gameManager.DisableOtherInputs(true);
        StartCoroutine("StormIn");
    }

    IEnumerator StormIn()
    {
        yield return new WaitForSeconds(stormIn.length);
        speechBubble.SetActive(true);
    }

    public void startStormOutCoroutine() {
        speechBubble.SetActive(false);
        StartCoroutine("StormOut");
    }

    IEnumerator StormOut()
    {
        gameObject.GetComponent<Animator>().SetTrigger("Leave");
        yield return new WaitForSeconds(stormOut.length);
        gameManager.DisableOtherInputs(false);
        gameObject.SetActive(false);
        Application.LoadLevel("TherapyGame");
    }

}