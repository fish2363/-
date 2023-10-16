using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quest2 : MonoBehaviour
{
    public GameObject plant;
   // public GameObject swiming;
    public GameObject doll;
    public bool inReach;
    float fix = 2.0f;
    public Text dirty;
    public GameObject arlim;
    public GameObject my;
    public GameObject bloom;


    // Start is called before the first frame update
    void Start()
    {
        fix = 0.0f;
       
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

        if (fix > 0)
        {
            fix -= Time.deltaTime;
        }
        else if (fix < 0)
        {
            dirty.text = " ";
            fix = 0.0f;
            arlim.SetActive(false);
            my.SetActive(false);
        }

        if (inReach && Input.GetButtonDown("Interact"))
        {
            fix = 3.0f;
            //미니맵 빗자루 안내 swiming.SetActive(true);
            plant.SetActive(false);
            doll.SetActive(false);
            dirty.text = "바닥이 좀 더러운 것 같아";
           // my.SetActive(false);
            arlim.SetActive(false);
            bloom.SetActive(true);
        }
    }
}
