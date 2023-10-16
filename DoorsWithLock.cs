using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DoorsWithLock : MonoBehaviour
{
    public Animator door;
    public GameObject openText;
    public GameObject KeyINV;
    public GameObject fillerINV; //물뿌리개를 가지고 밖으로 나가는것을 감지
    public float open;

    //public AudioSource doorSound;
    //public AudioSource lockedSound;


    public bool iReach;
    public bool unlocked;
    public bool locked;
    public bool hasKey;
    public bool Counting;
    public bool close;
    public GameObject Sound;
    public GameObject reach;
    public float sound;





    void Start()
    {
        iReach = false;
        hasKey = false;
        unlocked = false;
        locked = true;
        Counting = false;
        close = true;
    }

    void OnTriggerEnter(Collider other)
    {   
        if (close)
        {
            if (other.gameObject.tag == "Reach")
            {
                iReach = true;
                openText.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (close)
        {
            if (other.gameObject.tag == "Reach")
            {
                iReach = false;
                openText.SetActive(false);
            }
        }
    }





    void Update()
    {
        if (sound > 0)
        {
            sound -= Time.deltaTime;
        }
        else if (sound < 0)
        {
            sound = 0f;
            Sound.SetActive(false);
            reach.SetActive(true);
        }

        if (Counting)
        {
            if (open > 0)
            {
                open -= Time.deltaTime;
            }
            else if (open < 0)
            {
                surpOpens();
            }
        }

        if(KeyINV.activeInHierarchy)
        {
            //Debug.Log("열쇠");
            locked = false;
            hasKey = true;
        }
        else
        {
            hasKey = false;
        }

        if (fillerINV.activeInHierarchy)
        {
            //Debug.Log("열쇠");
            DoorCloses();
        }

        if (hasKey && iReach && Input.GetButtonDown("Interact"))
        {
            unlocked = true;
            DoorOpens();
        }

        if (locked && iReach && Input.GetButtonDown("Interact"))
        {
            //lockedSound.Play();
            Sound.SetActive(true);
            sound = 0.5f;
            reach.SetActive(false);
            openText.SetActive(false);
        }




    }
    void surpOpens()
    {
        door.SetBool("Open", false);
        door.SetBool("Closed", false);
        door.SetBool("2pen", true);
    }

    void DoorOpens()
    {
        if (unlocked)
        {
            door.SetBool("Open", true);
            door.SetBool("Closed", false);
            //    doorSound.Play();
            close = false;
            openText.SetActive(false);
        }

    }

    void DoorCloses()
    {
        door.SetBool("Open", false);
        door.SetBool("Closed", true);

        Counting = true;
    }


}
