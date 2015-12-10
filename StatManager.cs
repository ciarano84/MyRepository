using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StatManager : MonoBehaviour {
	
    //Handles all the stats that remain permanent across the game. Also has another sneaky duty of keeping tabs on which level
    //You are in and have previously arrived from.

	public static StatManager instance = null;

	public static int health = 4;
	public static int gamerScore = 0;
	public static int hygiene = 100;
    //Set at 80 to test the messSpawner
	public static int tidiness = 80;
	public static int hunger = 100;
    public static int social = 100;
    public static int independence = 50;
    public static int selfReflection = 90;

    public static List<GameObject> messItemsAvailable = new List<GameObject>();
    public static List<GameObject> spawnPointsAvailable = new List<GameObject>();

    public static string level;
    public static int currentMessNo = 0;

    MessSpawn messSpawn;
    void Awake () {
		//Make this a singleton (+declare instance above). Remember, no drag and drop references as it is instatiated from a prefab.
		if (instance == null)
			instance = this;
		else if (instance != null)
			Destroy (gameObject);
		DontDestroyOnLoad (gameObject);
	}

	void Start () {
        messSpawn = GameObject.Find("Mess Spawner").GetComponent<MessSpawn>();
        messItemsAvailable = messSpawn.messItemsMaster;
        spawnPointsAvailable = messSpawn.spawnPointsMaster;
        InvokeRepeating ("DeclineOverTime", 1, 10);
	}

	//Has the 3 composite stats of health degrade over time. This is called on a regular basis.
	void DeclineOverTime(){
		hygiene --;
		tidiness --;
		hunger --;
	}

	//clamps the values of the stats and sets the health stat.
	public static void UpdateHealth (){
		hygiene = Mathf.Clamp (hygiene, -100, 100);
		hunger = Mathf.Clamp (hunger, -100, 100);
		tidiness = Mathf.Clamp (tidiness, -100, 100);
        social = Mathf.Clamp(social, -100, 100);
        independence = Mathf.Clamp(independence, -100, 100);
        selfReflection = Mathf.Clamp(selfReflection, -100, 100);
        //taking the average of the above, then converting it into a value between 0 and 4, as per health chunk identifiers in the array.
        health = (int)Mathf.Floor ((((hunger + tidiness + hygiene
            + social) / 4) - 1) / 20);
        int previousMessNo = currentMessNo;
        currentMessNo = (int)(4 - Mathf.Floor((tidiness -1) / 20));
        if (previousMessNo <= currentMessNo)
        {
            GameObject.Find("Mess Spawner").GetComponent<MessSpawn>().updateMessList();
            GameObject.Find("Mess Spawner").GetComponent<MessSpawn>().MakeMess();
        }
    }
}
