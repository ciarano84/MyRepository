using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public float speed;
	public int pointsValue;
	public ShooterGameManager managerScript;
	public GameObject gameManager;

	GameObject player;

	void Awake(){
		player = GameObject.Find("MegaMan");
		//Find reference to the gameManager.
		gameManager = GameObject.Find ("ShooterGameManager");
		managerScript = gameManager.GetComponent<ShooterGameManager> ();
	}

	// Update is called once per frame
	void Update () {
		Vector3 direction = player.transform.position - transform.position;
		transform.Translate (direction * speed * Time.deltaTime);

	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Player"){
			managerScript.GameOver();
		}
	}

	void OnDestroy (){
		managerScript.UpdateScore(pointsValue);
	}
}
