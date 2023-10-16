using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textoff : MonoBehaviour
{
    public GameObject ttv; // = GameObject.Find("testcube"); 

    public int tvoff = 0;

    public Text tvof;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            tvof.text = "   ﻿";


        }

    }

}

