using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;
    public float moveX;
    public float moveY;
    public Rigidbody bodyForUse;

    public float jumpAmount;
    public bool jumpInput;

    public bool isGrounded;
    public float rotationSpeed;

    public Animator animcontroller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        if (jumpInput == false)
        {
            jumpInput = Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Joystick1Button0);
        }
    }

    private void FixedUpdate()
    {
        Vector3 newVelocity = new Vector3();
        newVelocity = bodyForUse.velocity;

        Vector3 camForward = Camera.main.transform.forward;
        Vector3 inputVector = new Vector3(moveX,0 ,moveY);
        camForward.y = 0;
        Quaternion camrot = Quaternion.LookRotation(camForward);
        inputVector = camrot * inputVector;

        newVelocity.x = moveX * Time.deltaTime * movementSpeed;
        newVelocity.z = moveY * Time.deltaTime * movementSpeed;

        

        if (jumpInput == true)
        {
            if (isGrounded)
            {
                newVelocity.y = jumpAmount;
            }
            jumpInput = false;
        }

        bodyForUse.velocity = newVelocity;

        Vector3 newRotation = new Vector3(newVelocity.x,0, newVelocity.z);
        transform.forward = Vector3.RotateTowards(transform.forward, newRotation, Time.deltaTime*rotationSpeed,0);

    }
}
