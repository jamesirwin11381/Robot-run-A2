using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isGrounded : MonoBehaviour
{
    public PlayerController controller;

    private void OnTriggerEnter(Collider other)
    {
        controller.isGrounded = true;
    }
    private void OnTriggerExit(Collider other)
    {
        controller.isGrounded = false;
    }






}
