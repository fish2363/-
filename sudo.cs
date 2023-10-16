using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sudo : MonoBehaviour
{
    float fix = 2.0f;
    public Text d;
    public GameObject arlim;
    public GameObject putfiller;
    public GameObject watersound;
    public bool inReach;
    public GameObject player;
    public GameObject filleritem;
    public GameObject my;
    public GameObject fillered;
    public GameObject timer;
    public GameObject bgm;

    // Start is called before the first frame update
    void Start()
    {
        fix = 2.0f;
        fillered.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {

            inReach = true;
            arlim.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            arlim.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(fix > 0)
        {
            fix -= Time.deltaTime;
        }
        else if (fix < 0)
        {
            d.text = " ";
            fix = 0.0f;
        }

        if (inReach && Input.GetButtonDown("Interact"))
        {
            Movement3D call = GameObject.Find("player").GetComponent<Movement3D>();
            call.moveSpeed = 0f;
            filleritem.SetActive(false);
            putfiller.SetActive(true);
            watersound.SetActive(true);
            bgm.SetActive(true);
            timer.SetActive(true);
            arlim.SetActive(false);
            my.SetActive(false);
        }
    }
}
