using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bloom : MonoBehaviour
{
    public GameObject my;
    public GameObject realmy;
    public GameObject getbloom;
    public GameObject arlim;
    public bool inReach;
    public GameObject gettbloom;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            Debug.Log("dddd");
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

    // Update is called once per frame
    void Update()
    {

        if (inReach && Input.GetButtonDown("Interact"))
        {
            //¹Ì´Ï¸Ê ºøÀÚ·ç ¾È³» swiming.SetActive(true);
            getbloom.SetActive(true);
            my.SetActive(false);
            realmy.SetActive(false);
            gettbloom.SetActive(true);
            arlim.SetActive(false);
        }
    }
}
