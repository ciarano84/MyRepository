using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	public GameObject enemy;
	public int enemyInterval = 3;

	Vector3 RandomSpawnPoint (){
		int x;
		int y;
		//Flip a coin...
		if (Random.Range (0, 2) == 0) {
			y = Random.Range (-9,10);
			//In this case have it come from the sides. Flip a coin for which side...
			x = (Random.Range (0,2) == 0)? -12 : 12;
				//In this case have it come from the left.
		} else {
			x = Random.Range (-12,12);
			//In this case have it come from the top or bottom. Flip a coin for which...
			y = (Random.Range (0,2) == 0)? -9 : 10;
		}
		Vector3 spawnPoint = new Vector3 (x,y,-2);
		return spawnPoint;
	}

	//spawn the enemies.
	void Spawn(){
		transform.position = RandomSpawnPoint ();
		Instantiate (enemy, RandomSpawnPoint(), Quaternion.identity);
	}

	//Call the spawn function regularly.
	void Start(){
		InvokeRepeating ("Spawn", enemyInterval, enemyInterval);
	}
}