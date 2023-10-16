using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tv_ele : MonoBehaviour
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
            
            tvof.text = "﻿TV가 들어오지 않는다.. 전력이 들어오지 않는 것 같은데,";

            
        }
      
    }
   
}

