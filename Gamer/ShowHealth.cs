using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowHealth : MonoBehaviour {

	//This relies upon the statmanager not changing the health stat immediately upon the scene starting. 
	//That way it can initialize the health bar, then (after say a second) show it updating. 

	public GameObject[] healthChunks = new GameObject[5];
    public GameObject statDropDown;
    public Text healthTrackerDebug;
    public Animator anim;
    public AnimationClip rollup;

	int previousChunk;
	
	void Start(){
        anim = statDropDown.GetComponent<Animator>();
        //initialy set up which chunks are to be set active.
        for (int i = 0 ; i <= StatManager.health ; i++){
			healthChunks[i].SetActive(true);
		}
	}

	//loop through each health chunk seeing if it needs to be active or inactive
	public void UpdateHealthBar (){
		for (int c = 0 ; c < healthChunks.Length ; c++){
			if (healthChunks[c].gameObject.activeSelf && StatManager.health < c){
				healthChunks[c].gameObject.SetActive (false);
			} else if (!healthChunks[c].gameObject.activeSelf && StatManager.health >= c){
				healthChunks[c].gameObject.SetActive (true);
			}
		}
	}

    public void showStatDropDown ()
    {
        statDropDown.SetActive(true);
    }

    public void closeStatDropDown()
    {
        anim.SetTrigger("Rollup");
        StartCoroutine("RollupAndDeactivate");
    }

    IEnumerator RollupAndDeactivate()
    {
        yield return new WaitForSeconds(rollup.length);
        statDropDown.SetActive(false);
    }

    
}
