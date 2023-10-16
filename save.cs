using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class save : MonoBehaviour
{
    public GameObject MenuSet;
    public Text alrim;
    public GameObject player;
    public GameObject questArim;

    // Start is called before the first frame update
    void Start()
    {
        MenuSet.SetActive(false);
        //alrim.text = "Tip 중요한 것들을 읽어보고 문을 열고 나가자";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (MenuSet.activeSelf)
            {
                player.GetComponent<Movement3D>().enabled = true;
                MenuSet.SetActive(false);
                questArim.SetActive(true);
            }
            else
            {
                player.GetComponent<Movement3D>().enabled = false;
                MenuSet.SetActive(true);
                questArim.SetActive(false);
            }
        }
            
            
    }

    public void Save()
    {
        //playerPrefs.SetFloat("playerX", player.transform.position.x);
        //playerPrefs.SetFloat("playerY", player.transform.position.y);
       // playerPrefs.Save();
    }
}
