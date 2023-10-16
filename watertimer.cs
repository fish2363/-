using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watertimer : MonoBehaviour
{
    float fillwater = 0.0f;
    public GameObject whosound;
    public GameObject bgmsound;
    public GameObject fillwatersound;
    public GameObject my;
    public GameObject putfiller;
    public GameObject questclear;
    public GameObject handfiller;

    // Start is called before the first frame update
    void Start()
    {
        fillwater = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        if (fillwater < 15) 
        {
            whosound.SetActive(true);
        }

        if (fillwater > 0)
        {
            fillwater -= Time.deltaTime;
        }
        else if (fillwater < 0)
        {
            questclear.SetActive(true);
            Movement3D call = GameObject.Find("player").GetComponent<Movement3D>();
            call.moveSpeed = 5f;
            fillwater = 0.0f;
            fillwatersound.SetActive(false);
            bgmsound.SetActive(false);
            whosound.SetActive(false );
            my.SetActive(false);
            putfiller.SetActive(false);
        }
    }
}
