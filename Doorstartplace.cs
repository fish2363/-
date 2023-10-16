using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Doorstartplace : MonoBehaviour
{
    public Animator door;
    public GameObject openText;
    float fix = 0.0f;
    public Text d;
    public bool x;
    float open;
    public GameObject player;
    public bool close;
    public GameObject sound2;
    public GameObject sound;
    public GameObject drop;
    //public AudioSource doorSound;


    public bool inReach;
    





    void Start()
    {
        inReach = false;
        x = false;
    }

    void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject.tag == "Reach")
        {
            if (open == 1)
            {
                openText.SetActive(false);
            }
            else
            {
                Debug.Log("dddd");
                inReach = true;
                openText.SetActive(true);
            }
            
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
            sound.SetActive(true);
        }

        if (inReach && Input.GetButtonDown("Interact"))
        {
            DoorOpens();
            
        }

        if (close == true)
        {
            DoorOpens();
            x = true;
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
        if (x == true)
        {
            Debug.Log("It Closes");
            door.SetBool("startclosed", true);
            door.SetBool("startopen", false);
            drop.SetActive(true);
        }
        else
        {

            open = 1;
            Debug.Log("It Opens");
            door.SetBool("startopen", true);
            door.SetBool("startclose", false);
            openText.SetActive(false);
            fix = 7.35f;
            sound2.SetActive(true);
        }
    }


}
