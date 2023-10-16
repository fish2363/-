using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questgo : MonoBehaviour
{
    public GameObject quest;
    public Text d;
    public GameObject player;
    float fix = 6.0f;
    public GameObject my;
    public GameObject next;

    // Start is called before the first frame update
    void Start()
    {
        fix = 0.0f;
        quest.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            player.GetComponent<Movement3D>().enabled = false;

            d.text = "�θ�Բ��� ���ñ� ������ �� ���� ��� ��������";
            quest.SetActive(true);

            fix = 3.0f;
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
            Movement3D jump = GameObject.Find("player").GetComponent<Movement3D>();
            jump.jumpForce = 3f;
            d.text = " ";
            fix = 0.0f;
            player.GetComponent<Movement3D>().enabled = true;
            next.SetActive(true);
            my.SetActive(false);

        }

    }
}
