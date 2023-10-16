using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorsboo : MonoBehaviour
{
    public bool scriptbooReach;
    public GameObject my;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            boo call = GameObject.Find("rcloset").GetComponent<boo>();
            call.openboo = true;

            my.SetActive(false);
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
