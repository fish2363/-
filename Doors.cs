using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Doors : MonoBehaviour
{
    public Animator door;
    public GameObject openText;
    float fix = 0.0f;
    public Text d;
    float open;
    public GameObject player;

    //public AudioSource doorSound;


    public bool inReach;

  //  Audio
   // AudioManager audioManager;



    void Start()
    {
        inReach = false;
        
    }

    private void Awake()
    {
      // audioManager = GameObject.FindGameObjectWithTag("audio").GetComponent<audioManager>();
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
        Movement3D jump = GameObject.Find("player").GetComponent<Movement3D>();
        jump.jumpForce = 0f;
        //   audioManager.PlaySFX(audioManager.doorsopen);
        open = 1;
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
