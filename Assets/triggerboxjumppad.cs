using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerboxjumppad : MonoBehaviour
{
    public float moveY;
    public Rigidbody bodyForUse;


    public void OnTriggerEnter(Collider other)
    {
        Vector3 newVelocity = new Vector3();
        newVelocity = bodyForUse.velocity;
        newVelocity.y = moveY;
        bodyForUse.velocity = newVelocity;
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
