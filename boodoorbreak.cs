using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boodoorbreak : MonoBehaviour
{
    public GameObject door;
    public GameObject breakdoor;
    public GameObject my;
    public GameObject esteregg;
    public GameObject sound;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            door.SetActive(false);
            esteregg.SetActive(false);
            breakdoor.SetActive(true);
            sound.SetActive(true);
            my.SetActive(false);
        }

    }
}
