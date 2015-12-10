using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    //This is the reference to the 3D navMesh agent that sits UNDERNEATH all the 2D stuff.
    public Transform target3D;
    public static string currentInstruction = "none";
    //This dictates what is controlling the gamer at any given time.
    [HideInInspector]
    public static string control;
    public AnimationClip jumpToComp;
    public AgentScript agentScript;
    public GameObject playGameScreen;
    public GameObject bell;
    public GameObject bellMenu;
    public float speed = 4;
    public struct destination {
        public string name;
        public Vector3 target;
    }

    Vector3 startPosition;
    Vector3 inChair;
    Vector3 door;
    Animator anim;

    void Start() {
        door = new Vector3(-4.3f, -20.5f, -3.26f);
        inChair = new Vector3(3.9f, -15.7f, -1.8f);
        anim = GetComponent<Animator>();
        //Set the starting position of the gamer and then set the level.
        switch (StatManager.level)
        {
            case "Therapy":
                transform.position = door;
                break;
            case "RPG":
                transform.position = inChair;
                break;
            case "Shooter":
                transform.position = inChair;
                break;
        }
        SwitchToNonAnimationControl();
        StatManager.level = "main";
        startPosition = transform.position;
    }
    
    void LateUpdate() {
        //This sets what controls the gamer's position.
        switch (control)
        {
            case "Animator":
                //Here the animator controls the position.
                break;
            case "ReturnToAgent":
                //Here the postion is controlled by the following script, allowing it to
                //smoothly return to the position required of it by the 3D agent.
                float step = speed * Time.deltaTime;
                Vector3 returnPoint = new Vector3
                    (target3D.position.x, transform.position.y, target3D.position.z + 0.75f);
                transform.position = Vector3.MoveTowards(transform.position, returnPoint, step);
                if (transform.position == returnPoint) {
                    control = "3DAgent";
                }
                break;
            default:
                //The default means it is under the control of the 3D agent.
                transform.position = new Vector3(target3D.position.x, transform.position.y, target3D.position.z + 0.75f);
                break;
        }
    }
    
    void OnTriggerEnter(Collider other) {
        if (currentInstruction == "bed" && other.name == "Bed Animation Trigger")
        {
            SwitchToAnimationControl("bed");
        }
        else if (currentInstruction == "computer" && other.name == "Computer Animation Trigger") {
            SwitchToAnimationControl("computer");
            StartCoroutine("WaitForCompAnimation");
            }
        else if (currentInstruction == "bell" && other.name == "Computer Animation Trigger")
        {
            SwitchToAnimationControl("computer");
            StartCoroutine("WaitForBellAnimation");
        }
    }

    public void MoveTo(destination moveToPoint) {
        agentScript.GetComponent<AgentScript>().SetStandPoint(moveToPoint.target);
        currentInstruction = moveToPoint.name;
    }

    IEnumerator WaitForCompAnimation() {
        yield return new WaitForSeconds(jumpToComp.length + 1);
        //this then brings up options for which game to play.
        playGameScreen.SetActive(true);
    }

    IEnumerator WaitForBellAnimation()
    {
        yield return new WaitForSeconds(jumpToComp.length + 1);
        bell.GetComponent<Animator>().SetTrigger("bell");
        yield return new WaitForSeconds(1);
        bellMenu.SetActive(true);
    }

    void SwitchToAnimationControl(string animationClip) {
        control = "Animator";
        currentInstruction = "none";
        GameManager.recieveInputs = false;
        anim.applyRootMotion = false; 
        anim.SetTrigger(animationClip);
    }

    public void SwitchToNonAnimationControl() {
        control = "ReturnToAgent";
        GameManager.recieveInputs = true;
        anim.applyRootMotion = true;
    }
}

