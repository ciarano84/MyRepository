using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShooterGameManager : MonoBehaviour {

	public Text scoreText;
	public GameObject gameOverScreen;

	int score;

    void Start() {
        StatManager.level = "Shooter";
    }

	public void UpdateScore(int points){
		score += points;
		if (scoreText != null) {
			scoreText.text = (score.ToString ());
		}
	}

	public void GameOver(){
		gameOverScreen.SetActive (true);
		StatManager.gamerScore += score / 10;
		StatManager.hygiene -= (Random.Range(1,10));
		StatManager.tidiness -= (Random.Range(1,10));
        StatManager.hunger -= (Random.Range(1,10));
		Invoke ("LoadMainLevel", 3);
	}

	void LoadMainLevel(){
		Application.LoadLevel ("main");
	}
}
