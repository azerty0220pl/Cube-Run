using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject character;
    public GameObject MainPanel;
    public GameObject GamePanel;
    public GameObject Right;
    public GameObject Left;
    int status = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Character")
        {
            //MainPanel.SetActive(true);
            GamePanel.SetActive(false);
            Right.GetComponent<MoveRight>().ispressed = false;
            Left.GetComponent<MoveLeft>().ispressed = false;
            PlayerPrefs.SetInt("state", 0);
            Debug.Log("calling character function");
            PlayerPrefs.SetFloat("realPoints", PlayerPrefs.GetFloat("points"));
            characterFunction();
        }
    }
    void characterFunction()
    {
        //character.transform.GetComponent<Rigidbody>().AddForce(transform.forward * 10);
        //character.transform.position = new Vector3(0f, -20f, 39f);
        //float i;
        status = 1;
        Rigidbody rig = character.GetComponent<Rigidbody>();
        rig.useGravity = true;
        Debug.Log("status set to 1");
        PlayerPrefs.SetFloat("realPoints", PlayerPrefs.GetFloat("points"));
        PlayerPrefs.SetInt("state", 0);
    }

    private void Update()
    {
        if (status < 1)
        {
            Rigidbody rig = character.GetComponent<Rigidbody>();
            //rig.useGravity = true;
            //Debug.Log("gravity set to 1");
            if (character.transform.position.y < -40)
            {
                rig.useGravity = false;
                rig.isKinematic = true;
                rig.isKinematic = false;
                status = 0;
                //Debug.Log("gravity and status set to 0");
                character.transform.position = new Vector3(0f, -20f, 39f);
                //i = 0;
            }
        }
    }
}
