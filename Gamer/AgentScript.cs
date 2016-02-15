using UnityEngine;
using System.Collections;

public class AgentScript : MonoBehaviour {

    public Vector3 bedLocation;

    NavMeshAgent agent;
    Vector3 travellingTo;
    bool travelling;

    void Start() {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameManager.recieveInputs == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Ground")
                {
                    travelling = false;
                    agent.SetDestination(hit.point);
                }
            }
        }
        if (travelling)
        {
            agent.SetDestination(travellingTo);
        }
    }

    public void SetStandPoint(Vector3 standPoint) {
        travelling = true;
        travellingTo = standPoint;
    }
}
