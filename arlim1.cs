using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arlim1 : MonoBehaviour
{
    public Text alrim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            alrim.text = "À¹ ¹¹ ÀÌ·¸°Ô ´õ·¯¿ö";
            


        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
