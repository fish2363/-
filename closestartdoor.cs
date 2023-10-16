using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closestartdoor : MonoBehaviour
{
    public Animator door;
    public bool close;
    public GameObject doors;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        close = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("dd");
        if (other.gameObject.tag == "Reach")
        {
            Movement3D jump = GameObject.Find("player").GetComponent<Movement3D>();
            jump.jumpForce = 0f;

            Doorstartplace call = GameObject.Find("start doors").GetComponent<Doorstartplace>();
            call.close = true;
            //DoorCloses();
        }
    }

    void DoorCloses()
    {
        Debug.Log("It Closes");
        //door.SetBool("startopen", false);
        //door.SetBool("startclosed", true);
    }
}
