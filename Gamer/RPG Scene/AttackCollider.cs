using UnityEngine;
using System.Collections;

public class AttackCollider : MonoBehaviour {

    public RPGGameManager rpgGameManager;

    void OnTriggerEnter(Collider other) {
        if ((other.gameObject.tag == "Orc" && gameObject.tag == "Sword") || (other.gameObject.tag == "Ghost" && gameObject.tag == "Spell"))
        {
            other.GetComponent<Monster>().TakeDamage(true);
            rpgGameManager.UpdateScore();
        }
    }
}
