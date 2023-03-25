using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public SpawnManager spawnManager;
    public float maxSpeed = 10f;
    public float acceleration = 5f;
    public float deceleration = 10f;
    public float turnSpeed = 50f;
    public float driftFactor = 0.9f;
    public float reverseSpeed = 5f;

    private float horizontalInput;
    private float verticalInput;
    private bool isBraking;
    private bool isDrifting;
    private bool isStopped;
    private bool isReversing;
    private float currentSpeed;
    private float turneffector;

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        isBraking = Input.GetKey(KeyCode.Space);
        isDrifting = Input.GetKey(KeyCode.LeftShift);
        isReversing = verticalInput < 0;
    }

    private void FixedUpdate()
    {
        turneffector = currentSpeed*currentSpeed/100;

        if (isReversing)
        {
            currentSpeed = Mathf.MoveTowards(currentSpeed, -maxSpeed, reverseSpeed * Time.deltaTime);
        }
        else if (isBraking)
        {
            currentSpeed = Mathf.MoveTowards(currentSpeed, 0, deceleration * Time.deltaTime);
        }
        else
        {
            currentSpeed = Mathf.MoveTowards(currentSpeed, maxSpeed * verticalInput, acceleration * Time.deltaTime);
        }

        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);

        
        if (currentSpeed < 0)
        {
            turneffector = -turneffector;
        }
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime * turneffector);
           
            
        


        if (isDrifting && Mathf.Abs(horizontalInput) > 0.1f && currentSpeed > 0)
        {
            
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime * driftFactor);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }
}