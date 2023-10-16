using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class waterfiller : MonoBehaviour
{
    public Text d;
    public GameObject my;
    public GameObject getfiller;
    public GameObject arlim;
    public bool inReach;
    public GameObject fillwater; //물 채우는곳 활성화


    // Start is called before the first frame update
    void Start()
    {

    }

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

    // Update is called once per frame
    void Update()
    {

            if (inReach && Input.GetButtonDown("Interact"))
        {
            d.text = "물을 채워야겠다";
            //미니맵 빗자루 안내 swiming.SetActive(true);
            getfiller.SetActive(true);
            fillwater.SetActive(true);
            arlim.SetActive(false);
        }
    }
}
