using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerboxlight : MonoBehaviour
{

    public GameObject redlight;
    public GameObject greenlight;



    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            redlight.SetActive(false);
            greenlight.SetActive(true);
        }
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
