using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject mouseOverAreas;
	public GameObject clickToMoveAreas;
	public GameObject mom;
	public GameObject dad;
	public GameObject gameOverScreen;
    public GameObject selfReflectionGameOverScreen;
    public Text finalScore;
	//The percentage chance that dad will turn up in a minute.
	public int rarityOfDad = 2;
	//for testing purposes, we'll allow users to lower how often it checks for dad.
	public int testForDad = 4;
	public Text gamerScoreText;
	public ShowHealth showHealth;
    public static bool recieveInputs = true;

	void Start (){
		gamerScoreText.text = ("GAMERSCORE: " + StatManager.gamerScore);
		//get the statmanager to work out the health (and then tell the healthbar). does this on a delay so that the 
		//healthbar can set it at what it WAS before showing it changing to what it IS now.
		InvokeRepeating ("DelayHealthUpdate",1,10);
		InvokeRepeating ("CallForDad",5,6);
    }

	void DelayHealthUpdate (){
		StatManager.UpdateHealth ();
        if (StatManager.health <= 0) {
            gameOverScreen.SetActive(true);
        } else if (StatManager.selfReflection >= 100) {
            selfReflectionGameOverScreen.SetActive(true);
            finalScore.text = "Final Gamerscore: " + StatManager.gamerScore;
        }
		showHealth.UpdateHealthBar ();
	}
		
	//Toggles all interactable areas in the bedroom scene.
	public void DisableOtherInputs(bool state){
		if (state == true) {
			mouseOverAreas.SetActive (false);
            recieveInputs = false;
		} else if (state == false) {
			mouseOverAreas.SetActive (true);
            recieveInputs = true;
        }
	}

	//When this is called a random check is made to see if Dad turns up.
	public void CallForDad(){
		int rand = Random.Range(0,rarityOfDad);
		if (rand == 0){
			dad.SetActive (true);
		}
	}	

	public void LoadShooterGame(){
		Application.LoadLevel ("ShooterGame");
	}

    public void LoadRPGGame()
    {
        Application.LoadLevel("RPGGame");
    }
}
