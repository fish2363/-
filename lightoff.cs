using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightoff : MonoBehaviour
{
    public GameObject obj;
    public GameObject meinvi;

    public int light = 0;

    void Start()
    {
       meinvi.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
         obj.SetActive(true);   
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
