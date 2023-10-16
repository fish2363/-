using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class videoend : MonoBehaviour
{
    float setTime = 10.0f;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(setTime);

        if (setTime > 0)
        {
            setTime -= Time.deltaTime;
        }
        else if (setTime <= 0)
        {

          SceneManager .LoadScene("tvnext");
        }



    }
}
