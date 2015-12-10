using UnityEngine;
using System.Collections;

public class SideScroll : MonoBehaviour {

    public float scrollSpeed;

    private Vector3 startPosition;

    void Start()
    {
        //Find starting position
        startPosition = transform.position;
    }

    void Update()
    {
        //This detirmines the position the background is going to move to, looping when it gets past a certain point.
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, 19.8f);
        //This then relocates the background to the new position (which eventually will be back where it started due to looping above).
        transform.position = startPosition + Vector3.right * -newPosition;
    }
}