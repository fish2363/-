using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class fill : MonoBehaviour
{
    public GameObject arlim;
    public bool inReach;
    public GameObject clear;
    public GameObject my;
    public GameObject filler;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
         
            inReach = true;
            arlim.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            arlim.SetActive(false);
        }
    }
    void Update()
    {
        if (inReach && Input.GetButtonDown("Interact"))
        {
            filler.SetActive(false);
            clear.SetActive(true);       
            arlim.SetActive(false);
            my.SetActive(false);
        }
    }
}
