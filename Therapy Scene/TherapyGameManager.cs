using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TherapyGameManager : MonoBehaviour {

    public GameObject gamerUIBar;
    public GameObject therapistUIBar;
    public GameObject therapist;
    public GameObject gameOverFailScreen;
    public GameObject gameOverSuccessScreen;
    public int damagePerDefence = 10;
    public int selfReflectionGainOnFail = 10;

    public static int gamerResolve;
    public static int therapistResolve;

    [HideInInspector]
    public bool gameActive = true;

    void Start()
    {
        StatManager.level = "Therapy";
        gamerResolve = 100;
        therapistResolve = 100;
        updateResolve();
        OverToTheTherapist();
    }

    public void OverToTheTherapist() {
        if (gameActive){
            therapist.GetComponent<Intervene>().WaitThenIntervene();
        }
    }

    public void updateResolve() {
        gamerUIBar.GetComponent<UIBarScript>().UpdateValue(gamerResolve,100);
        therapistUIBar.GetComponent<UIBarScript>().UpdateValue(therapistResolve, 100);
        if (therapistResolve <= 0 || gamerResolve <= 0)
        {
            gameOver();
        }
    }

    void gameOver() {
        gameActive = false;
        Invoke("ReturnToMainScene", 5);
        if (gamerResolve <= 0)
        {
            gameOverFailScreen.SetActive(true);
            StatManager.selfReflection += selfReflectionGainOnFail;
        } else if (therapistResolve <= 0) {
            gameOverSuccessScreen.SetActive(true);
        }
    }

    void ReturnToMainScene() {
        Application.LoadLevel("main");
    }
}
