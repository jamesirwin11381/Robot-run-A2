using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed;
    public float moveX;
    public Rigidbody bodyForUse;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        Vector3 newVelocity = new Vector3();
        newVelocity = bodyForUse.velocity;
        newVelocity.x = moveX * Time.deltaTime * movementSpeed;
        bodyForUse.velocity = newVelocity;
    }
}
