using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int currspeed;
    private float maxSpeed;
    private float stoppingTime;
    private bool willstop;
    private float maxstopingdistance;

    // Start is called before the first frame update
    void Start()
    {
        currspeed = 2;
         

    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(Vector3.forward * currspeed * Time.deltaTime);
    }

}
