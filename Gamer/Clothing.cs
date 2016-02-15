using UnityEngine;
using System.Collections;

public class Clothing : MonoBehaviour {

    public Sprite mouseover;
    public Sprite mouseexit;

    float speed = 20;
    Vector3 target = new Vector3(5.61f, -15.69f, -1.28f);

    void OnMouseOver() {
        GetComponent<SpriteRenderer>().sprite = mouseover;
    }

    void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().sprite = mouseexit;
    }

    void OnMouseUp() {
        GameObject.Find("Agent").GetComponent<AgentScript>().SetStandPoint
            (new Vector3 (transform.position.x, -20.5f, transform.position.z));
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player")
            print("called");
        StartCoroutine("TidyAway");
    }

    IEnumerator TidyAway() {
        float step = speed * Time.deltaTime;
        for (float f = 1f; transform.localScale.x >= 0; f -= 0.005f)
        {
            transform.localScale -= new Vector3 (1-f, 1-f, 1-f);
            transform.position = Vector3.MoveTowards(transform.position, target, step);
            yield return null;
        }
        Destroy(gameObject);
    }
}
