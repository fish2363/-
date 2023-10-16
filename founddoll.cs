using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class founddoll : MonoBehaviour
{
    public bool cuti;
    public bool last;
    public bool gusend;
    public bool end;
    public GameObject finish;
    public Text GG;
    float fix = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        cuti = false;
        last = false;
        gusend = false;
        end = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cuti")
        {
            cuti = true;
            if (last)
            {
                if (gusend)
                {
                    end = true;
                }
            }
            if (gusend)
            {
                if (last)
                {
                    end = true;
                }
            }
        }
        if (other.tag == "last")
        {
            last = true;
            if (cuti)
            {
                if (gusend)
                {
                    end = true;
                }
            }
            if (gusend)
            {
                if (cuti)
                {
                    end = true;
                }
            }
        }
        if (other.tag == "gusend")
        {
            gusend = true;
            if (last)
            {
                if (cuti)
                {
                    end = true;
                }
            }
            if (cuti)
            {
                if (last)
                {
                    end = true;
                }
            }
        }
    }
    void Update ()
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

        if (end)
        {
            finish.SetActive(true);
            GG.text = "다신 멋대로 날 떠나지마";
        }
    }

}
