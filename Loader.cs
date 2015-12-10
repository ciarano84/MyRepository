using UnityEngine;
using System.Collections;

public class Loader : MonoBehaviour {

	public GameObject statManager;
	
	void Awake () {
		//Check if a statManager has already been assigned to static variable statManager.instance or if it's still null
		if (StatManager.instance == null)
			
			//Instantiate gameManager prefab
			Instantiate(statManager);
    }
}
