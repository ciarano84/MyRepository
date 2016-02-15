using UnityEngine;
using System.Collections;

public class Defend : MonoBehaviour {

    
    public GameObject defence;
    public GameObject therapyGameManager;

    Vector3[] spawnPoints = new Vector3[4];

    void Start()
    {
        therapyGameManager = GameObject.Find("TherapyGameManager");

        spawnPoints[0] = new Vector3(-120, 63, -1);
        spawnPoints[1] = new Vector3(-87, 65, -1);
        spawnPoints[2] = new Vector3(-99, 52, -1);
        spawnPoints[3] = new Vector3(-89, 42, -1);
    }

    public void DefendYourself()
    {
        TherapyGameManager.therapistResolve -= therapyGameManager.GetComponent<TherapyGameManager>().damagePerDefence;
        therapyGameManager.GetComponent<TherapyGameManager>().updateResolve();
        if (therapyGameManager.GetComponent<TherapyGameManager>().gameActive)
        Instantiate(defence, spawnPoints[Random.Range(0, 4)], Quaternion.identity);
    }
}
