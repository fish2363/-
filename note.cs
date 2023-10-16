using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note : MonoBehaviour
{
    public Animator Note;
    public bool see;

    // Start is called before the first frame update
    public void OnClick()
    {
        if (see == true)
        {
            Note.SetBool("down", true);
            Note.SetBool("up", false);
            see = false;
        }
        else
        {
            Note.SetBool("up", true);
            Note.SetBool("down", false);
            see = true;
        }
    }

    // Update is called once per frame
    void Start()
    {
        Debug.Log("start");
        see = false;
    }
}
