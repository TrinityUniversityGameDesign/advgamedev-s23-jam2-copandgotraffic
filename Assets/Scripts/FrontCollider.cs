using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontCollider : MonoBehaviour
{

    public GameObject parent;
    public float frontspeed;
    // Start is called before the first frame update
    void Start()
    {
        parent = gameObject.transform.parent.gameObject;
    }

    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Car")
        {
            Debug.Log("toodles");
            Debug.Log(collider.gameObject);
            frontspeed = collider.gameObject.GetComponent<NPC_Car>().currspeed;
            if (frontspeed < gameObject.transform.parent.GetComponent<NPC_Car>().maxSpeed)
            {
                gameObject.transform.parent.GetComponent<NPC_Car>().currspeed = frontspeed;
            }
            gameObject.transform.parent.GetComponent<NPC_Car>().tracked = true;
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        gameObject.transform.parent.GetComponent<NPC_Car>().tracked = false;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
