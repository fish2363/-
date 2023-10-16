using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questcompl : MonoBehaviour
{
    public GameObject fini1;
    public GameObject fini2;
    public GameObject fini3;
    public GameObject firstquest;
    public GameObject secondquest;
    public GameObject thirdquest;
    public GameObject tv;
    public GameObject broom;
    public GameObject broomodel;
    public bool brush;
    public bool plant;
    public bool doll;
    public Text GG;
    float fix = 2.0f;
    public bool tvgo;

    // Start is called before the first frame update
    void Start()
    {
        brush = false;
        plant = false;
        doll = true; //(아직 안 만듦)
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "finish2")
        {
            broom.SetActive(false);
            broomodel.SetActive(false);
            brush = true;
            fini2.SetActive(false);
            if (plant)
            {
                firstquest.SetActive(false);
            }
            else
            {
                firstquest.SetActive(true);
            }
            if (doll)
            {
                thirdquest.SetActive(false);
            }
            else
            {
                thirdquest.SetActive(true);
            }
        }
        if (other.tag == "finish1")
        {
            plant = true;
            fini1.SetActive(false);

            if (brush)
            {
                secondquest.SetActive(false);
            }
            else
            {
                secondquest.SetActive(true);
            }
            if (doll)
            {
                thirdquest.SetActive(false);
            }
            else
            {
                thirdquest.SetActive(true);
            }
        }
        if (other.tag == "finish3")
        {
            doll = true;
            fini3.SetActive(false);
            if (plant)
            {
                firstquest.SetActive(false);
            }
            else
            {
                firstquest.SetActive(true);
            }
            if (brush)
            {
                secondquest.SetActive(false);
            }
            else
            {
                secondquest.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        

        if (fix > 0)
        {
            fix -= Time.deltaTime;
        }
        else if (fix <= 0)
        {
            GG.text = "   ";
            fix = 0.0f;

        }

        if (brush && doll && plant)
        {
            tv.SetActive(true);
            GG.text = "다 한것 같으니 TV로 가라는 내용";
            tvgo = true;
            fix = 2.5f;
            doll = false;
            brush = false;
            plant = false;
        }
    }
}
