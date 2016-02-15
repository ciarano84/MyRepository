using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowSubStats : MonoBehaviour {

    public Text hungerText;
    public Text hygieneText;
    public Text tidinessText;
    public Text socialText;
    public Text independenceText;
    public Text selfReflectionText;

	void Update () {
        hungerText.text = "Hunger: " + StatManager.hunger.ToString();
        hygieneText.text = "Hygiene: " + StatManager.hygiene.ToString();
        tidinessText.text = "Tidiness: " + StatManager.tidiness.ToString();
        socialText.text = "Social: " + StatManager.social.ToString();
        independenceText.text = "Independence: " + StatManager.independence.ToString();
        selfReflectionText.text = "selfReflection: " + StatManager.selfReflection.ToString();
    }
}
