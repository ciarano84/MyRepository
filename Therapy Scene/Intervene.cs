using UnityEngine;
using System.Collections;

public class Intervene : MonoBehaviour {

    public int minWaitToIntervene = 2;
    public int maxWaitToIntervene = 5;
    public GameObject intervention;

    Vector3[] spawnPoints = new Vector3[4];

    void Start () {
        spawnPoints[0] = new Vector3(0, 0, -1);
        spawnPoints[1] = new Vector3(0, -65, -1);
        spawnPoints[2] = new Vector3(23, 60, -1);
        spawnPoints[3] = new Vector3(99, 58, -1);
    }

    public void WaitThenIntervene() {
        Invoke("MakeIntervention", Random.Range(minWaitToIntervene, maxWaitToIntervene));
    }

    void MakeIntervention () {
        Instantiate (intervention, spawnPoints[Random.Range(0, 4)], Quaternion.identity); 
	}
}