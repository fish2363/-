using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.Characters.FirstPerson;


public class ReadNotes : MonoBehaviour
{
    public GameObject player;
    public GameObject noteUI;
    public GameObject hud;

    public GameObject pickUpText;

    //public AudioSource pickUpSound;

    public bool inReach;



    void Start()
    {
        noteUI.SetActive(false);
        hud.SetActive(true);
        pickUpText.SetActive(false);

        inReach = false;
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            pickUpText.SetActive(true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            pickUpText.SetActive(false);
        }
    }




    void Update()
    {
        if(Input.GetButtonDown("Interact") && inReach)
        {
            noteUI.SetActive(true);
            //pickUpSound.Play();
            hud.SetActive(false);
            player.GetComponent<Movement3D>().enabled = false;
            Cursor.visible = true; //커서
            Cursor.lockState = CursorLockMode.None;
        }
        
    }


    public void ExitButton()
    {
        noteUI.SetActive(false);
        hud.SetActive(true);
        player.GetComponent<Movement3D>().enabled = true;

    }
}
