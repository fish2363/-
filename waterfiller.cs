using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class waterfiller : MonoBehaviour
{
    public Text d;
    public GameObject my;
    public GameObject getfiller;
    public GameObject arlim;
    public bool inReach;
    public GameObject fillwater; //�� ä��°� Ȱ��ȭ


    // Start is called before the first frame update
    void Start()
    {

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

            if (inReach && Input.GetButtonDown("Interact"))
        {
            d.text = "���� ä���߰ڴ�";
            //�̴ϸ� ���ڷ� �ȳ� swiming.SetActive(true);
            getfiller.SetActive(true);
            fillwater.SetActive(true);
            arlim.SetActive(false);
        }
    }
}
