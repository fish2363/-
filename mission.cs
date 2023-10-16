using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mission : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject last;
    public GameObject end;
    public GameObject oneText;
    public GameObject my;
    public GameObject light;
    public GameObject range;

    float fix = 6.0f; 

    public bool first;
    public bool secon;
    public bool endd;
    public bool inReach;
    public bool getout;

    void Start()
    {
        inReach = false;
        first = false;
        secon = false;
        endd = false;
        getout = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            Debug.Log("dddd");
            inReach = true;
            oneText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            oneText.SetActive(false);
        }
    }


    void Update()
    {
        if (getout && Input.GetButtonDown("Interact"))
        {
            my.SetActive(false);
            light.SetActive(true);
        }


        if (inReach && endd && Input.GetButtonDown("Interact"))
        {
            oneText.SetActive(false);
            endd = false;
            getout = true;
            range.SetActive(false);

            if (fix > 0)
            {
                fix -= Time.deltaTime;
            }
            else if (fix <= 0)
            {
                range.SetActive(true);
                fix = 6.0f;
            }
        }
        else if (inReach && secon && Input.GetButtonDown("Interact"))
        {
            oneText.SetActive(false);
            secon = false;
            endd = true;
            range.SetActive(false);

            if (fix > 0)
            {
                fix -= Time.deltaTime;
            }
            else if (fix <= 0)
            {
                range.SetActive(true);
                fix = 6.0f;
            }
        }
        else if (inReach && first && Input.GetButtonDown("Interact"))
        {
            oneText.SetActive(false);
            first = false;
            secon = true;
            range.SetActive(false);

            if (fix > 0)
            {
                fix -= Time.deltaTime;
            }
            else if (fix <= 0)
            {
                range.SetActive(true);
                fix = 6.0f;
            }
        }
        else if (inReach && Input.GetButtonDown("Interact"))
        {
            oneText.SetActive(false);
            first = true;
            range.SetActive(false);

            if (fix > 0)
            {
                fix -= Time.deltaTime;
            }
            else if (fix <= 0)
            {
                range.SetActive(true);
                fix = 6.0f;
            }
        }
    }





}
