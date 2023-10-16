using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brush : MonoBehaviour
{
    //public bool brush;
    public bool tra1;
    public bool tra2;
    public bool tra3;
    public bool click;
    public bool fclean;
    public bool sclean;
    public bool tclean;
    public bool inReach;
    public bool oneend;
    public bool twoend;
    public bool thrend;
    public GameObject arlim;
    //public Text arlim;
    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public Text clean;
    float fix = 2.0f;
    float cleaner = 2.0f;
    public GameObject playbroom;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject finish;



    // Start is called before the first frame update
    void Start()
    {
        fix = 0.0f;
        click = false;
        tra1 = false;
        tra2 = false;
        tra3 = false;
    }


void OnTriggerEnter(Collider other)
{
    if (other.gameObject.tag == "trash")
    {
        Debug.Log("trash");
        tra1 = true;
        arlim.SetActive(true);
        inReach = true;
        click = false;
    }
    if (other.gameObject.tag == "trash2")
    {
        Debug.Log("trash2");
        tra2 = true;
        arlim.SetActive(true);
        inReach = true;
        click = false;
    }
    if (other.gameObject.tag == "trash3")
    {
        Debug.Log("trash3");
        tra3 = true;
        arlim.SetActive(true);
        inReach = true;
        click = false;
    }
}

void OnTriggerExit(Collider other)
{

    if (other.gameObject.tag == "trash")
    {
        Debug.Log("outrash");
        inReach = false;
        tra1 = false;
        arlim.SetActive(false);
    }
    if (other.gameObject.tag == "trash2")
    {
        Debug.Log("outrash2");
        inReach = false;
        tra2 = false;
        arlim.SetActive(false);
    }
    if (other.gameObject.tag == "trash3")
    {
        Debug.Log("outrash3");
        inReach = false;
        tra3 = false;
        arlim.SetActive(false);
    }
}

// Update is called once per frame
void Update()
{
        if (oneend && twoend && thrend)
        {
            //모든 쓰레기 처리 완료
            finish.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (inReach)
            {
                Debug.Log("click");
                click = true;
            }
            else
            {
                Debug.Log(inReach);
                Debug.Log("click 3" + click);
                fix = 1.5f;
                clean.text = "이쪽은 닦을 필요가 없을 것 같아";
            }
        }

        if (fix > 0)
        {
            fix -= Time.deltaTime;
        }
        else if (fix < 0)
        {
            clean.text = " ";
            fix = 0.0f;

        }

        if (cleaner > 0)
        {
            cleaner -= Time.deltaTime;
        }
        else if (cleaner < 0)
        {
            playbroom.SetActive(true);
            cleaner = 0.0f;
            b1.SetActive(false);
            b2.SetActive(false);
            b3.SetActive(false);
            if (fclean)
            {
                t1.SetActive(false);
                tclean = false;
                sclean = false;
                fclean = false;
                oneend = true;
            }
            if (sclean)
            {
                t2.SetActive(false);
                tclean = false;
                sclean = false;
                fclean = false;
                twoend = true;
            }
            if (tclean)
            {
                t3.SetActive(false);
                tclean = false;
                sclean = false;
                fclean = false;
                thrend = true;
            }
        }

        if (click == true)
        {
            if (tra1 && tra2 == false && tra3 == false)
            {
                Debug.Log("ohohohooh");
                b1.SetActive(true);
                cleaner = 3.2f;
                playbroom.SetActive(false);
                fclean = true;
            }
            if (tra2 && tra1 == false && tra3 == false)
            {
                b2.SetActive(true);
                cleaner = 3.2f;
                playbroom.SetActive(false);
                sclean = true;

            }
            if (tra3 && tra2 == false && tra1 == false)
            {
                b3.SetActive(true);
                cleaner = 3.2f;
                playbroom.SetActive(false);
                tclean = true;
            }
        }
    }
}
