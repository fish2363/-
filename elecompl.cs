using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class elecompl : MonoBehaviour
{
    public GameObject sinho;
    public GameObject lighof;
    public GameObject media;
    float fix = 2.0f;

    public Text eleco;

    int invivi;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            eleco.text = "전기가 복구된 것 같다";
            sinho.SetActive(false);
            lighof.SetActive(true);
            media.SetActive(true);
            fix = 2.5f;

        }

    }
    void Update()
    {
        if (fix > 0)
        {
            fix -= Time.deltaTime;
        }
        else if (fix < 0)
        {
            eleco.text = " ";
            fix = 0.0f;

        }

    }

}

