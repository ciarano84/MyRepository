using UnityEngine;
using System.Collections;

public class shot : MonoBehaviour {
	
	public float speed = 1;

	Vector3 direction;	

	void Start(){
		//Find a reference to the gunBarrel to get the direction to shoot in.
		GameObject shooting = GameObject.Find("GunBarrel");
		direction = shooting.GetComponent<Shooting>().gunToMouse.normalized;
		//Clean up the shots after they have created themselves.
		Destroy (gameObject, 3);
	}

	void Update (){
		//Move towards the cursor.
		transform.Translate (direction * speed * Time.deltaTime);
	}

	//detect the player if hit and call game over (to be finished).
	void OnTriggerEnter (Collider other){
		if (other.tag == "Enemy") {
			Destroy (other.gameObject);
		}
	}
}
