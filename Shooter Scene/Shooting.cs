using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {


	public float shotRate;
	public GameObject shot;
	public GameObject megaMan;
	[HideInInspector] public Vector3 gunToMouse;

	AudioSource gunAudio;
	Ray camRay;
	RaycastHit floorHit;
	Vector3 unFlipped = new Vector3 (0.69375f,0.5875003f,1);
	Vector3 flipped = new Vector3 (-0.69375f,0.5875003f,1);

	void Update (){
		camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		// Perform the raycast and if it hits something on the floor layer... //I took out the floormask perameter from the end.
		if (Physics.Raycast (camRay, out floorHit, 100)) {
			// Create a vector from the player to the point on the floor the raycast from the mouse hit.
			gunToMouse.x = floorHit.point.x - transform.position.x;
			gunToMouse.y = floorHit.point.y - transform.position.y;
		}
		//Trial code to flip the image, using the ray's floorHit variable to see where the mouse is.
		if (floorHit.point.x < 0) {
			megaMan.transform.localScale = flipped;
		} else {
			megaMan.transform.localScale = unFlipped;
		}
	}

	void Start(){
		//Call the shot creation function
		InvokeRepeating ("createShot", shotRate, shotRate);
		gunAudio = GetComponent<AudioSource> ();
	}

	void createShot (){
		//Creates the shots at the gunbarrel.
		gunAudio.Play();
		Instantiate (shot, transform.position, Quaternion.identity);
	}
}
