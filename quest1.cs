using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class quest1 : MonoBehaviour
{
    //수정필요
    public GameObject arlim;
    public GameObject plant;
    public GameObject other;
    public GameObject other2;
    public GameObject my;
    public Text findwater;
    public GameObject note;
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
            findwater.text = "  ";
            fix = 0.0f;
            arlim.SetActive(false);
            my.SetActive(false);
        }

        if (inReach && Input.GetButtonDown("Interact"))
        {
            fix = 3.0f;
            other.SetActive(false);
            other2.SetActive(false);
            findwater.text = "식물한테는 물이 필요해, 내가 가져다 줘야겠어";
            arlim.SetActive(false);
            plant.SetActive(true);
            note.SetActive(true);

        }
    }
}

