using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MessSpawn : MonoBehaviour {

    //What to do to avoid this getting destroyed on load!

    public List<GameObject> messItemsMaster = new List<GameObject>();
    public List<GameObject> spawnPointsMaster = new List<GameObject>();

    public struct messItem {
        public GameObject clothing;
        public Vector3 place;
    }
    //keep this next list in statmanager?
    static public List<messItem> messItemsCurrent = new List<messItem>();
    static public List<int> itemBlackList = new List<int>();
    static public List<int> placeBlackList = new List<int>();

    int previousTideness;
    int tidinessCheck = 81;
    // array to hold the existing gameobjects so we can destroy them to place new ones.
    GameObject[] toBeCleared;

    void Start() {
    }

    public void updateMessList() {
        for (int i = 0; i <= StatManager.currentMessNo || i <= messItemsCurrent.Count; i++) {
            print("messNo  = " + StatManager.currentMessNo + " and count = " + messItemsCurrent.Count);
            if (i <= StatManager.currentMessNo && i > messItemsCurrent.Count) {     
                messItem m;
                int itemPicked = Random.Range(0, StatManager.messItemsAvailable.Count - 1);
                m.clothing = StatManager.messItemsAvailable[itemPicked];
                StatManager.messItemsAvailable.RemoveAt(itemPicked);
                int placePicked = Random.Range(0, StatManager.spawnPointsAvailable.Count - 1);
                // debug section
                int c = 0;
                foreach (GameObject g in StatManager.spawnPointsAvailable)
                {
                    print (" at " + c + " is " + g.transform.position);
                    c++;
                }
                print("random spawnPoint is " + placePicked);
                // debug section over
                m.place = StatManager.spawnPointsAvailable[placePicked].transform.position;
                StatManager.spawnPointsAvailable.RemoveAt(placePicked);
                messItemsCurrent.Add(m);
            }
            // Add in option for removal later on...
        }
    }

    //This clears out all existing mess (to prevent duplicates) and places the mess.
    public void MakeMess()
    {
        toBeCleared = GameObject.FindGameObjectsWithTag("Mess");
        foreach (GameObject g in toBeCleared) {
            Destroy(g);
        }
        foreach (messItem m in messItemsCurrent)
        {
            Instantiate(m.clothing, m.place, Quaternion.Euler(45, 0, 0));
        }
    }

    //This is called by the Mom script, and puts away all clothes. 
    public void TidyRoom() {
    }
}
