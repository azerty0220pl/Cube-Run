using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
    public GameObject Character;
    public GameObject coin;
    public GameObject mainPanel;
    public GameObject overPanel;
    public GameObject winPanel;
    public GameObject arcadeEnd;
    int coins;
    public Text coinText;

    private void Start()
    {
        Advertisement.Initialize("3254184", false);
    }

    public void rewardedVideo()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            Advertisement.Show("rewardedVideo");
            Debug.Log("Ready and showing rewarded video");
            coins = PlayerPrefs.GetInt("coins");
            coins = coins + 25;
            PlayerPrefs.SetInt("coins", coins);
            coinText = coin.GetComponent<Text>();
            coinText.text = "" + coins;
        }
    }

    public void Continue()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            Advertisement.Show("rewardedVideo");
            Debug.Log("Ready and showing rewarded video");
            mainPanel.SetActive(true);
            overPanel.SetActive(false);
            //Character.GetComponent<CharacterController>().points = PlayerPrefs.GetFloat("points");
        }
    }

    public void zero()
    {
        PlayerPrefs.SetFloat("points", 0);
    }

    public void rewardFive()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            Advertisement.Show("rewardedVideo");
            Debug.Log("Ready and showing rewarded video");
            coins = PlayerPrefs.GetInt("coins");
            coins = coins + 80;
            PlayerPrefs.SetInt("coins", coins);
            coinText = coin.GetComponent<Text>();
            coinText.text = "" + coins;
            winPanel.SetActive(false);
            mainPanel.SetActive(true);
        }
    }

    public void rewardArcade()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            Advertisement.Show("rewardedVideo");
            Debug.Log("Ready and showing rewarded video");
            coins = PlayerPrefs.GetInt("coins");
            coins = coins + PlayerPrefs.GetInt("arcadeMoney") * 4;
            PlayerPrefs.SetInt("coins", coins);
            coinText = coin.GetComponent<Text>();
            coinText.text = "" + coins;
            arcadeEnd.SetActive(false);
            mainPanel.SetActive(true);
        }
    }
}
