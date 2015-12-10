using UnityEngine;
using System.Collections;

public class MouseOverAreas : MonoBehaviour {
	
	public GameManager gameManager;
    //The menu that is brought up when you click on it.
    public GameObject display;
    public Vector3 standPoint;
    public AgentScript agentScript;
    //Tells the gamer which action to take.
    public Movement movement;
    public string Instruction;

    MeshRenderer boxColor;
    

	void Start (){
		boxColor = GetComponent<MeshRenderer> ();
	}

	void OnMouseOver(){
		boxColor.enabled = true;
	}

	void OnMouseExit(){
		boxColor.enabled = false;
	}

	//Turns on the menu and turns of other functionality. Calls the player over if not there already.
	void OnMouseUp (){
		boxColor.enabled = false;
        if (display != null)
		display.SetActive (true);
        //gameManager.DisableOtherInputs (true);
        agentScript.GetComponent<AgentScript>().SetStandPoint(standPoint);
        if (Instruction != null)
            Movement.currentInstruction = Instruction;
    }

	//Turns off the menu and starts other functionality in the room.
	public void CloseMenu (){
        if (display != null)
		display.SetActive (false);
		gameManager.DisableOtherInputs (false);
	}
}
