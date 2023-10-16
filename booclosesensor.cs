using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class booclosesensor : MonoBehaviour
{
    public GameObject my;
    public GameObject doorbreak;
    public GameObject esteregg;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            boo call = GameObject.Find("rcloset").GetComponent<boo>();
            call.close = true;

            esteregg.SetActive(true);
            my.SetActive(false);
            doorbreak.SetActive(true);
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
