using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class keyroom : MonoBehaviour
{
    public GameObject openText;
    public bool boo1Reach;
    public GameObject boo;
    public bool knock;

    void OnTriggerEnter(Collider other)
    {
        if (knock)
        {
            openText.SetActive(false);
        }
        else if (other.gameObject.tag == "Reach")
            {
                boo1Reach = true;
                openText.SetActive(true);
            }

    }

    void OnTriggerExit(Collider other)
    {
            if (other.gameObject.tag == "Reach")
            {
                  boo1Reach = false;
                openText.SetActive(false);
            }
    }

        void Update()
    {
        if (boo1Reach && Input.GetButtonDown("Interact"))
        {
            boo.SetActive(true);
            openText.SetActive(false);
        }
    }
        
       
            
        
}
 