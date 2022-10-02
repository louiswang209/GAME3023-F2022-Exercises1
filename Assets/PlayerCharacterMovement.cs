using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterMovement : MonoBehaviour
{

    [SerializeField]
    [Range(0,10)]
    float MoveSpeed = 1;

    [SerializeField]
    Rigidbody2D rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        Vector3 currentPostion = transform.position;

        rigidbody.MovePosition(currentPostion + new Vector3(inputX, inputY, 0) * MoveSpeed * Time.deltaTime);
        //transform.position = currentPostion + new Vector3(inputX, inputY, 0) * MoveSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Player collided with: " + collision.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player Triggered with: " + collision.gameObject.name);
    }
}

