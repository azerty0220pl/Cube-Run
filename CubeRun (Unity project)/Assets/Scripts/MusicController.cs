using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public GameObject ButtonOn;
    public GameObject ButtonOff;
    public GameObject musicObject;
    
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("musicState") == 0) MusicOn();
        if (PlayerPrefs.GetInt("musicState") == 1) MusicOff();
    }

    public void MusicOn()
    {
        ButtonOn.SetActive(true);
        ButtonOff.SetActive(false);
        musicObject.SetActive(true);
        PlayerPrefs.SetInt("musicState", 0);
    }

    public void MusicOff()
    {
        ButtonOn.SetActive(false);
        ButtonOff.SetActive(true);
        musicObject.SetActive(false);
        PlayerPrefs.SetInt("musicState", 1);
    }

    
}
