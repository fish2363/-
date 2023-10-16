using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plantkeyDoors : MonoBehaviour
{
    public Animator door;
    public GameObject openText;
    float fix = 0.0f;
    public Text d;
    public GameObject player;

    //public AudioSource doorSound;


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


        if (fix > 0)
        {
            fix -= Time.deltaTime;
        }
        else if (fix < 0)
        {
            fix = 0.0f;
            player.GetComponent<Movement3D>().enabled = true;

        }

        if (inReach && Input.GetButtonDown("Interact"))
        {
            DoorOpens();
            
        }
        //else
        {
           // DoorCloses();
        }

      //  if (op = true)
        {
       //     if (inReach && Input.GetButtonDown("Interact"))
            {
        //        DoorCloses();
          //      op = false;
            }
        }
    }

    void DoorOpens ()
    {
        Debug.Log("It Opens");
        door.SetBool("Open", true);
        door.SetBool("Closed", false);
        openText.SetActive(false);
        fix = 3.0f;
        player.GetComponent<Movement3D>().enabled = false;

    }

    void DoorCloses()
   {
         Debug.Log("It Closes");
            door.SetBool("Open", false);
           door.SetBool("Closed", true);
   }


}
