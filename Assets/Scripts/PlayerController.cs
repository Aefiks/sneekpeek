using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;

    public float jumpForce = 5f;

    public float moveSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
        //mo¿na proœciej: Vector3.right

        float horizontalInput = Input.GetAxisRaw("Horizontal");

        Vector3 movement = Vector3.right * horizontalInput;

        float verticalInput = Input.GetAxisRaw("Vertical");

        movement += Vector3.forward * verticalInput;

        movement = movement.normalized;
        movement *= Time.deltaTime;
        movement *= moveSpeed;


        transform.Translate(movement);

        
    }
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    void Jump()
    {

        if (transform.position.y <= Mathf.Epsilon)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {

        
        if(other.CompareTag("LevelEnd"))
        {

            GameObject.Find("LevelManager").GetComponent<LevelManager>().OnWin();
        }
        if(other.CompareTag("CameraView"))
        {

            GameObject.Find("LevelManager").GetComponent<LevelManager>().OnLose();

        }
    }
}
