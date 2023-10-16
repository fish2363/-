using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quest3 : MonoBehaviour
{
    public GameObject arlim;
    public GameObject doll;
    public GameObject doll2;
    public GameObject other;
    public GameObject other2;
    public GameObject my;
    public GameObject wall;
    public Text finddoll;
    public GameObject player;
    float fix = 3.0f;

    public bool inReach;
    // Start is called before the first frame update
    void Start()
    {
        fix = 0.0f;
        //plant.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            Debug.Log("dddd");
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

    void Update()
    {
        //Debug.Log(fix);
        if (fix > 0)
        {
            fix -= Time.deltaTime;
        }
        else if (fix < 0)
        {
            finddoll.text = "  ";
            fix = 0.0f;
            arlim.SetActive(false);
            my.SetActive(false);
        }

        if (inReach && Input.GetButtonDown("Interact"))
        {
            fix = 3.0f;
            other.SetActive(false);
            other2.SetActive(false);
            finddoll.text = "네 친구들은 어디갔니?";
            arlim.SetActive(false);
            doll.SetActive(true);
            doll2.SetActive(true);
            wall.SetActive(false);

        }
    }
}