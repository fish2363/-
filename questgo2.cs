using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questgo2 : MonoBehaviour
{
    float fix = 2.0f;
    public Text d;
    public GameObject player;
    public GameObject my;
    public GameObject key;

    // Start is called before the first frame update
    void Start()
    {
      //  Rigidbody rb = key.GetComponent<Rigidbody>();
    //    Destroy(rb);
        fix = 0.0f;


    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
         //   Vector3 vec;
       //     vec = Vector3.zero;

       //     player.GetComponent<Movement3D>().enabled = false;
            d.text = "무슨 할 일을 먼저할까?";
            fix = 2.0f;
           // Movement3D call = GameObject.Find("player").GetComponent<Movement3D>();
          //  call.gravity = 0f;
          //  player.AddComponent<Rigidbody>();
         //   BoxCollider bcd = my.GetComponent<BoxCollider>();
           // Destroy(bcd);
            // Rigidbody prb
            // prb.isKinematic = true;
        }
    }

    void Update()
    {
        Debug.Log(fix);

        if (fix > 0)
        {
            fix -= Time.deltaTime;
        }
        else if (fix < 0)
        {
            d.text = " ";
            fix = 0.0f;
            my.SetActive(false);
        //    player.GetComponent<Movement3D>().enabled = true;
            // Rigidbody prb = player.GetComponent<Rigidbody>();
            // Destroy(prb);
            my.AddComponent<BoxCollider>();
          //  Movement3D call = GameObject.Find("player").GetComponent<Movement3D>();
         //   call.gravity = -9.81f;
        }

        if (player.transform.position.y < 2.1f)
        {
         //   Rigidbody prb = player.GetComponent<Rigidbody>();
         //   Destroy(prb);
        }

    }
}
