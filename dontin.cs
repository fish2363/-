using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dontin : MonoBehaviour
{
    public bool inReach;
    public GameObject openText;

    void Start()
    {
        inReach = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
        }
    }

    void Update()
    {
        if (inReach && Input.GetButtonDown("Interact"))
        {
            openText.SetActive(true);
        }
    }
}
