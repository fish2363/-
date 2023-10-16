using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notstartdoors : MonoBehaviour
{
    public GameObject openText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            openText.SetActive(true);
        }
    }

void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            openText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
