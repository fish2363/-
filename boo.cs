using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boo : MonoBehaviour
{
    public Animator closetani;
    float fix = 0.0f;
    public bool closet;
    public bool close;
    public bool openboo;
    public GameObject sensor;
    public GameObject closesound;
    public GameObject opensound;



    void Start()
    {
        close = false;
        closet = false;
        openboo = false;
    }

    void Update()
    {
        if (openboo == true)
        {
            DoorOpens();
        }
        if (close == true) 
        {
            DoorOpens();
            closet = true;
        }
    }

    void DoorOpens()
    {
        closetani.SetBool("booclosetopen", true);
        closetani.SetBool("boocloset", false);
        closesound.SetActive(true);
        sensor.SetActive(true);

        if (closet == true)
        {
            closetani.SetBool("boocloset", true);
            closetani.SetBool("booclosetopen", false);
            opensound.SetActive(true);
        }
    }


}