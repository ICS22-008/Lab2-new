using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    private float horMovement;
    private float vertMovement;
    private float speed = 7f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horMovement = Input.GetAxis("Horizontal");
        vertMovement = Input.GetAxis("Vertical");
       
        //transform.position += movement;
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(horMovement, 0, vertMovement) * Time.deltaTime * speed * 100;

        //rb.AddForce(movement);
        rb.velocity = movement;
    }
}
