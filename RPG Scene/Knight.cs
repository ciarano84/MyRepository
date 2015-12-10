using UnityEngine;
using System.Collections;

public class Knight : MonoBehaviour {

    public GameObject attackCollider;
    public GameObject magicSpell;
    public RPGGameManager rpgGameManager;
    public Animator anim;
    public AnimationClip knightAttack;
    public GameObject powerUpSign;

    public int pushBack = 2;
    public int damage = 4;

    bool casting = false;
    public bool magicArmour = false;
    public bool magicSword = false;

    void Start() {
        anim = GetComponent<Animator>();
    }

    public void Attack() {
        anim.SetTrigger("sword");
        Invoke("Damage", knightAttack.length * 0.5f);
        Invoke("DamageOver", knightAttack.length);
    }

    //Turns on the magicSpell child object
    public void CastSpell()
    {
        if (!casting) {
            magicSpell.SetActive(true);
            casting = true;
            Invoke("SpellOver", 0.75f);
        }
    }

    //Turns on the collider that detects enemies and then kills them.
    void Damage() {
        attackCollider.SetActive(true);
    }

    //Turns off the magic spell
    void SpellOver() {
        magicSpell.SetActive(false);
        casting = false;
    }

    //Turns off said collider.
    void DamageOver() {
        attackCollider.SetActive(false);
    }

    public void TakeDamage(int damage) {
        anim.SetTrigger("damaged");
        //Take damage from health... if magic Armour is equipped then half that.
        RPGGameManager.RPGhealth -= (magicArmour ? damage/2 : damage);
        rpgGameManager.GetComponent<RPGGameManager>().UpdateHealth();
        rpgGameManager.GetComponent<RPGGameManager>().UpdateScore();
    }

    public void getMagicSword() {
        magicSword = true;
        powerUpSign.SetActive(true);
        damage = damage * 2;
    }

    public void getMagicArmour() {
        magicArmour = true;
        GetComponent<SpriteRenderer>().material.SetColor("_Color", Color.red);
    }
}
