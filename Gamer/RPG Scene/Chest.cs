using UnityEngine;
using System.Collections;

public class Chest : Encounter {

    public Knight knight;
    public int chestXPReward = 200;

    private Vector3 startPosition;
    private float startTime;
    Animator anim;

    void Start() {
        anim = GetComponent<Animator>();
        startPosition = transform.position;
        startTime = Time.time;
        knight = GameObject.Find("Knight").GetComponent<Knight>();
        manager = GameObject.Find("RPGGameManager").GetComponent<RPGGameManager>();
    }

    void Update() {
        GameObject background = GameObject.Find("Dungeon Background");
        float newPosition = ((Time.time - startTime) * background.GetComponent<SideScroll>().scrollSpeed);
        transform.position = startPosition + Vector3.right * -newPosition;
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" && other.tag != "spell") {
            anim.SetTrigger("Open");
            RandomFind();
            //Destroy itself or it will keep looping past the player.
            Destroy(gameObject, 4);
        }
    }

    public void RandomFind() {
        int rand = Random.Range(0, 3);
        if (rand == 1 && !knight.magicArmour)
        {
            knight.getMagicArmour();
            Reward("Magic\nArmour!", 0);
        }
        else if (rand == 2 && !knight.magicSword)
        {
            knight.getMagicSword();
            Reward("Magic\nWeapon!", 0);
        }
        else {
            Reward("treasure", chestXPReward * RPGGameManager.multiplier);
            RPGGameManager.score += chestXPReward * RPGGameManager.multiplier;
            manager.UpdateScore();
        }
    }
}

