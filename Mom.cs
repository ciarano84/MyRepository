using UnityEngine;
using System.Collections;

public class Mom : MonoBehaviour {

	public GameManager gameManager;
	public AnimationClip doStuff;
	public int amountReplenished = 20;

	string statToReplenish;

	void OnEnable (){
		gameManager.DisableOtherInputs (true);
		StartCoroutine ("PlayAnimationThenDie");
	}

	public void OrderFood (){
		gameObject.SetActive (true);
		statToReplenish = "hunger";
	}
	
	public void GetBathed (){
		gameObject.SetActive (true);
		statToReplenish = "hygiene";
	}
	
	public void TidyRoom (){
		gameObject.SetActive (true);
		statToReplenish = "tidiness";
	}

    public void NoAction() {
        GameObject.Find("Bell Menu").SetActive(false);
        GameObject.Find("Gamer").GetComponent<Movement>().SwitchToNonAnimationControl();
    }

	//Moves her into the room.
	IEnumerator PlayAnimationThenDie ()
	{
        GameObject.Find("Bell Menu").SetActive(false);
        //This finds the midpoint of the animation (bit gammy) to affect the stats.
		yield return new WaitForSeconds (doStuff.length/2);
		switch (statToReplenish) {
		case "hunger":
			StatManager.hunger += amountReplenished;
			break;
		case "hygiene":
			StatManager.hygiene += amountReplenished;
			break;
		case "tidiness":
            StatManager.tidiness = 100;
            GameObject.Find("Mess Spawner").GetComponent<MessSpawn>().TidyRoom();
			break;
		}
		//Then finishes the animation.
		yield return new WaitForSeconds (doStuff.length/2);
		gameObject.SetActive(false);
        GameObject.Find("Gamer").GetComponent<Movement>().SwitchToNonAnimationControl();
	}
}
