using UnityEngine;
using System.Collections;

public class Monster : Encounter {

    public int health = 10;
    public int damage = 20;
    public int points = 100;

    GameObject knight;

	void Start () {
        knight = GameObject.Find("Knight");
    }

    //Deals damage to the player upon collision, takes damage
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            knight.GetComponent<Knight>().TakeDamage(damage);
            TakeDamage(false);
        }
    }

    public void TakeDamage(bool hitByPlayer) {
        //Deal damage
        health -= knight.GetComponent<Knight>().damage;
        //Knock them back
        Rigidbody rigid = GetComponent<Rigidbody>();
        rigid.AddForce(transform.right * knight.GetComponent<Knight>().pushBack, ForceMode.Impulse);
        //Kill them and grant a reward
        if (health <= 0)
        {
            Destroy(gameObject);
            Reward("hello", points * RPGGameManager.multiplier);
            RPGGameManager.score += points * RPGGameManager.multiplier;
        }

    }
}
