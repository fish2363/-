using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bababa : MonoBehaviour
{
    public GameObject openText;
    public GameObject noele;
    float tex = 4.0f;

    public bool inReach;

    void Start()
    {
        inReach = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            Debug.Log("dddd");
            inReach = true;
            openText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            openText.SetActive(false);
        }
    }


    void Update()
    {
        Debug.Log(tex);

        if (inReach && Input.GetButtonDown("Interact"))
        {
            noele.SetActive(true);
            openText.SetActive(false);

            if (tex > 0)
            {
                tex -= Time.deltaTime;
            }
            else if (tex <= 0)
            {
                noele.SetActive(false);
                tex = 4.0f;
            }
        }
    }



}
