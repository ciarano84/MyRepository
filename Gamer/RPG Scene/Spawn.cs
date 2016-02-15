using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawn : MonoBehaviour {

    public int noEncounterFreq;
    public List<Encounter> Encounters = new List<Encounter>();

    List<Encounter> EncounterTable = new List<Encounter>();

    void Start () {
        CreateEncounterTable(Encounters);

        InvokeRepeating("CheckForSpawn", 1, 1);
    }

    void CreateEncounterTable(List<Encounter> encounters) {
        foreach (Encounter g in encounters) {
            for (int i = 0; i < g.frequency; i++) {
                EncounterTable.Add(g);
            }
        }
    }

    //Randomly checks to see if monster is present
    public void CheckForSpawn()
    {
        int rand = Random.Range(0, EncounterTable.Count + noEncounterFreq);
        print(rand);
        if (rand >= EncounterTable.Count)
        {
            return;
        } else {
            Instantiate(EncounterTable[rand], transform.position, Quaternion.identity);
        }
    }
}
