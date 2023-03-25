using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Car : MonoBehaviour
{
    public float currspeed;
    public float maxSpeed;
    private bool willstop;
    private float acceleration;
    public bool tracked;
    private float breakingSpeed;
    private bool stopping;
    private float slowspeed;
    //private float maxdistance;

    // Start is called before the first frame update
    void Start()
    {
        currspeed = 0f;
        maxSpeed = Random.Range(1f, 10f);
        breakingSpeed = 0.08f;
        slowspeed = 1f;
        acceleration = 0.05f;
        if (Random.Range(.1f,1f) > .1) { willstop = true; }
        else { willstop = false; }
        

    }

    // Update is called once per frame
    void Update()
    {
        if (stopping)
        {
            if (currspeed > slowspeed) currspeed -= breakingSpeed = 0f;
            if (currspeed < slowspeed)
            {
                currspeed = slowspeed;
            }
            
        }
        else
        {
            if (!tracked)
            {
                if (currspeed < maxSpeed) currspeed += acceleration;

            }
            if (currspeed > maxSpeed) currspeed = maxSpeed;
            if (Random.Range(0f, 1f) > 0.95f)
            {
                stopping = true;
                StartCoroutine(Stop_Stopping());
                
            }
        }
        transform.Translate(Vector3.forward * currspeed * Time.deltaTime);

    }
    IEnumerator Stop_Stopping()
    {
        yield return new WaitForSeconds(10);
        stopping = false;
    }

}


