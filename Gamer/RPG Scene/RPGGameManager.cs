using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RPGGameManager : MonoBehaviour {

    public GameObject uIBar;
    public GameObject gameOverScreen;
    public GameObject XPText;
    public Text levelText;
    public Text scoreText;
    public Text finalScoreText;
    public Text multiplierText;
    public int pointsPerLevel;
    public GameObject knight;

    public static int RPGhealth = 100;
    public static int score = 0;
    public static int multiplier = 1;

    int level = 1;
    

    void Start() {
        RPGhealth = 100;
        score = 0;
        multiplier = 1;
        UpdateHealth();
        //Can we replace the next two lines with updateScore() ?
        scoreText.text = "SCORE: " + score;
        levelText.text = ("Level " + level);
        StatManager.level = "RPG";
    }

	public void UpdateHealth () {
        uIBar.GetComponent<UIBarScript>().UpdateValue(RPGhealth, 100);
        if (RPGhealth <= 0)
        {
            finalScoreText.text = "FINAL SCORE " + score;
            gameOverScreen.SetActive(true);
            knight.SetActive(false);
            Invoke("ReturnToMainScene", 5);
        }
	}

    public void UpdateScore() {
        scoreText.text = "SCORE: " + score;
        checkForLevelUp();
    }

    void ReturnToMainScene() {
        Application.LoadLevel("main");
    }

    void checkForLevelUp() {
        int levelBeforeIncrease = level;
        level = (int)Mathf.Max(1, Mathf.Floor((Mathf.Log((score / 1000), 2)) + 1) + 1);
        if (level > levelBeforeIncrease) {
            levelUp();
        }
        levelText.text = ("Level " + level);
    }

    void levelUp()
    {
        Vector3 position = new Vector3(knight.transform.position.x + 2, knight.transform.position.y + 4, knight.transform.position.z);
        GameObject XP = (GameObject)Instantiate(XPText, position, Quaternion.identity);
        XP.GetComponent<TextMesh>().text = "Level " + level;
        int originalMultiplier = multiplier;
        multiplier = (int)Mathf.Floor((level / 3) + 1);
        
        if (originalMultiplier < multiplier)
        {
            multiplierText.text = "x" + multiplier;
            multiplierText.GetComponent<Animator>().SetTrigger("grow");
        }
    }
}
