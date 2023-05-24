using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsChanger : MonoBehaviour
{
    public GameObject buttonSwipe;
    public GameObject buttonTap;
    public GameObject SwipeGameObject;
    public GameObject button1;
    public GameObject button2;

    int state;

    private void Start()
    {
        state = PlayerPrefs.GetInt("controlState");

        if (state == 0)
            SwipeChange();
        if (state == 1)
            TapChange();
    }

    public void SwipeChange()
    {
        buttonSwipe.SetActive(true);
        buttonTap.SetActive(false);
        SwipeGameObject.GetComponent<SwipeController>().enabled = true;
        button1.SetActive(false);
        button2.SetActive(false);
        PlayerPrefs.SetInt("controlState", 0);
    }

    public void TapChange()
    {
        buttonSwipe.SetActive(false);
        buttonTap.SetActive(true);
        SwipeGameObject.GetComponent<SwipeController>().enabled = false;
        button1.SetActive(true);
        button2.SetActive(true);
        PlayerPrefs.SetInt("controlState", 1);
    }
}
