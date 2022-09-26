using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    [SerializeField]
    [Range(0,10)]
    float MoveSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        Vector3 currentPostion = transform.position;

        transform.position = currentPostion + new Vector3(inputX, inputY, 0) * MoveSpeed * Time.deltaTime;
    }
}
