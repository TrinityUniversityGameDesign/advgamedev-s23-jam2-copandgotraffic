using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalFollow : MonoBehaviour
{
    
    [SerializeField] private float moveSpeed = 5f;
    public float acceleration = 5f;
    public float deceleration = 10f;
    public Transform playerTransform;
    private Rigidbody rb;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float targetX = playerTransform.position.x;
        Vector2 currentPos = transform.position;
        moveSpeed = moveSpeed * acceleration;
        currentPos.x = Mathf.MoveTowards(currentPos.x, targetX, moveSpeed * Time.deltaTime);
        rb.MovePosition(currentPos);
    }
}
