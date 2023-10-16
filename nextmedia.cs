using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextmedia : MonoBehaviour
{
    public GameObject play;
    public GameObject scene;
    // Start is called before the first frame update
    void Start()
    {
        play.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {


            SceneManager.LoadScene("media");


        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
