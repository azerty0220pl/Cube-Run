using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public GameObject cylinder1;
    public GameObject cylinder2;
    public GameObject cylinder3;
    public GameObject cylinder4;
    public GameObject cylinder5;
    public GameObject cylinder6;

    int left;
    public GameObject noMoneyText;
    Text moneyText;

    public GameObject sky;
    public GameObject cloud1;
    public GameObject cloud2;
    public GameObject cloud3;
    public GameObject cloud4;
    public GameObject cloud5;
    public GameObject cloud6;

    public Material world1Cylinder1;
    public Material world1Cylinder2;
    public Material world2Cylinder1;
    public Material world2Cylinder2;
    public Material world3Cylinder1;
    public Material world3Cylinder2;
    public Material world4Cylinder1;
    public Material world4Cylinder2;
    public Material matCloud1;
    public Material matCloud2;
    public Material matCloud3;
    public Material matCloud4;
    public Material sky1;
    public Material sky2;
    public Material sky3;
    public Material sky4;

    public GameObject skin1;
    public GameObject skin2;
    public GameObject skin3;
    public GameObject skin4;
    public GameObject skin5;
    public GameObject skin6;
    public GameObject skin7;
    public GameObject skin8;
    public GameObject skin9;
    public GameObject skin10;
    public GameObject skin11;
    public GameObject skin12;

    public GameObject noMoney;

    int prize2;
    int prize3;
    int prize4;
    int prize5;
    int prize6;
    int prize7;
    int prize8;
    int prize9;
    int prize10;
    int prize11;
    int prize12;

    int skinState;
    int maxSkin;
    int coins;
    float speed;
    float maxPostemp;

    void Start()
    {
        prize2 = 40;
        prize3 = 60;
        prize4 = 80;
        prize5 = 100;
        prize6 = 160;
        prize7 = 240;
        prize8 = 300;
        prize9 = 400;
        prize10 = 500;
        prize11 = 600;
        prize12 = 750;

        skinState = PlayerPrefs.GetInt("skinState");
        maxSkin = PlayerPrefs.GetInt("maxSkin");

        LoadSkin();
    }

    public void moveLeft()
    {
        skinState = PlayerPrefs.GetInt("skinState");
        skinState = skinState - 1;
        PlayerPrefs.SetInt("skinState", skinState);
        LoadSkin();
    }

    public void moveRight()
    {
        skinState = PlayerPrefs.GetInt("skinState");
        maxSkin = PlayerPrefs.GetInt("maxSkin");
        if (skinState < maxSkin)
        {
            skinState = skinState + 1;
            PlayerPrefs.SetInt("skinState", skinState);
            LoadSkin();
        }
        else
        {
            BuySkin();
        }
    }

    void BuySkin()
    {
        coins = PlayerPrefs.GetInt("coins");

        if (maxSkin == 0)
        {
            if (coins >= prize2 || PlayerPrefs.GetInt("premium") == 1)
            {
                maxSkin = maxSkin + 1;
                PlayerPrefs.SetInt("maxSkin", maxSkin);
                moveRight();
                coins = coins - prize2;
                PlayerPrefs.SetInt("coins", coins);
            }
            else
            {
                noMoney.SetActive(true);
                moneyText = noMoneyText.GetComponent<Text>();
                left = prize2 - coins;
                moneyText.text = "You need " + left + " coins more.";
            }
        }
        else if (maxSkin == 1)
        {
            if (coins >= prize3 || PlayerPrefs.GetInt("premium") == 1)
            {
                maxSkin = maxSkin + 1;
                PlayerPrefs.SetInt("maxSkin", maxSkin);
                moveRight();
                coins = coins - prize3;
                PlayerPrefs.SetInt("coins", coins);
            }
            else
            {
                noMoney.SetActive(true);
                moneyText = noMoneyText.GetComponent<Text>();
                left = prize3 - coins;
                moneyText.text = "You need " + left + " coins more.";
            }
        }
        else if (maxSkin == 2)
        {
            if (coins >= prize4 || PlayerPrefs.GetInt("premium") == 1)
            {
                maxSkin = maxSkin + 1;
                PlayerPrefs.SetInt("maxSkin", maxSkin);
                moveRight();
                coins = coins - prize4;
                PlayerPrefs.SetInt("coins", coins);
            }
            else
            {
                noMoney.SetActive(true);
                moneyText = noMoneyText.GetComponent<Text>();
                left = prize3 - coins;
                moneyText.text = "You need " + left + " coins more.";
            }
        }
        else if (maxSkin == 3)
        {
            if (coins >= prize5 || PlayerPrefs.GetInt("premium") == 1)
            {
                maxSkin = maxSkin + 1;
                PlayerPrefs.SetInt("maxSkin", maxSkin);
                moveRight();
                coins = coins - prize5;
                PlayerPrefs.SetInt("coins", coins);
            }
            else
            {
                noMoney.SetActive(true);
                moneyText = noMoneyText.GetComponent<Text>();
                left = prize5 - coins;
                moneyText.text = "You need " + left + " coins more.";
            }
        }
        else if (maxSkin == 4)
        {
            if (coins >= prize6 || PlayerPrefs.GetInt("premium") == 1)
            {
                maxSkin = maxSkin + 1;
                PlayerPrefs.SetInt("maxSkin", maxSkin);
                moveRight();
                coins = coins - prize6;
                PlayerPrefs.SetInt("coins", coins);
            }
            else
            {
                noMoney.SetActive(true);
                moneyText = noMoneyText.GetComponent<Text>();
                left = prize6 - coins;
                moneyText.text = "You need " + left + " coins more.";
            }
        }
        else if (maxSkin == 5)
        {
            if (coins >= prize7 || PlayerPrefs.GetInt("premium") == 1)
            {
                maxSkin = maxSkin + 1;
                PlayerPrefs.SetInt("maxSkin", maxSkin);
                moveRight();
                coins = coins - prize7;
                PlayerPrefs.SetInt("coins", coins);
            }
            else
            {
                noMoney.SetActive(true);
                moneyText = noMoneyText.GetComponent<Text>();
                left = prize7 - coins;
                moneyText.text = "You need " + left + " coins more.";
            }
        }
        else if (maxSkin == 6)
        {
            if (coins >= prize8 || PlayerPrefs.GetInt("premium") == 1)
            {
                maxSkin = maxSkin + 1;
                PlayerPrefs.SetInt("maxSkin", maxSkin);
                moveRight();
                coins = coins - prize8;
                PlayerPrefs.SetInt("coins", coins);
            }
            else
            {
                noMoney.SetActive(true);
                moneyText = noMoneyText.GetComponent<Text>();
                left = prize8 - coins;
                moneyText.text = "You need " + left + " coins more.";
            }
        }
        else if (maxSkin == 7)
        {
            if (coins >= prize9 || PlayerPrefs.GetInt("premium") == 1)
            {
                maxSkin = maxSkin + 1;
                PlayerPrefs.SetInt("maxSkin", maxSkin);
                moveRight();
                coins = coins - prize9;
                PlayerPrefs.SetInt("coins", coins);
            }
            else
            {
                noMoney.SetActive(true);
                moneyText = noMoneyText.GetComponent<Text>();
                left = prize9 - coins;
                moneyText.text = "You need " + left + " coins more.";
            }
        }
        else if (maxSkin == 8)
        {
            if (coins >= prize10 || PlayerPrefs.GetInt("premium") == 1)
            {
                maxSkin = maxSkin + 1;
                PlayerPrefs.SetInt("maxSkin", maxSkin);
                moveRight();
                coins = coins - prize10;
                PlayerPrefs.SetInt("coins", coins);
            }
            else
            {
                noMoney.SetActive(true);
                moneyText = noMoneyText.GetComponent<Text>();
                left = prize10 - coins;
                moneyText.text = "You need " + left + " coins more.";
            }
        }
        else if (maxSkin == 9)
        {
            if (coins >= prize11 || PlayerPrefs.GetInt("premium") == 1)
            {
                maxSkin = maxSkin + 1;
                PlayerPrefs.SetInt("maxSkin", maxSkin);
                moveRight(); coins = coins - prize11;
                PlayerPrefs.SetInt("coins", coins);
            }
            else
            {
                noMoney.SetActive(true);
                moneyText = noMoneyText.GetComponent<Text>();
                left = prize11 - coins;
                moneyText.text = "You need \n" + left + " coins more.";
            }
        }
        else if (maxSkin == 10)
        {
            if (coins >= prize12 || PlayerPrefs.GetInt("premium") == 1)
            {
                maxSkin = maxSkin + 1;
                PlayerPrefs.SetInt("maxSkin", maxSkin);
                moveRight();
                coins = coins - prize12;
                PlayerPrefs.SetInt("coins", coins);
            }
            else
            {
                noMoney.SetActive(true);
                moneyText = noMoneyText.GetComponent<Text>();
                left = prize12 - coins;
                moneyText.text = "You need " + left + " coins more.";
            }
        }
    }

    public void LoadSkin()
    {
        if (skinState == 0)
        {
            skin1.SetActive(true);
            skin2.SetActive(false);
            skin3.SetActive(false);
            skin4.SetActive(false);
            skin5.SetActive(false);
            skin6.SetActive(false);
            skin7.SetActive(false);
            skin8.SetActive(false);
            skin9.SetActive(false);
            skin10.SetActive(false);
            skin11.SetActive(false);
            skin12.SetActive(false);

            speed = 0.75f;
            PlayerPrefs.SetFloat("speed", speed);
            maxPostemp = 200f;
            PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
            PlayerPrefs.SetInt("easy", 50);
            PlayerPrefs.SetInt("medium", 80);
            PlayerPrefs.SetInt("divider", 30);

            sky.GetComponent<Renderer>().material = sky1;
            cloud1.GetComponent<Renderer>().material = matCloud1;
            cloud2.GetComponent<Renderer>().material = matCloud1;
            cloud3.GetComponent<Renderer>().material = matCloud1;
            cloud4.GetComponent<Renderer>().material = matCloud1;
            cloud5.GetComponent<Renderer>().material = matCloud1;
            cloud6.GetComponent<Renderer>().material = matCloud1;
            cylinder1.GetComponent<Renderer>().material = world1Cylinder1;
            cylinder2.GetComponent<Renderer>().material = world1Cylinder2;
            cylinder3.GetComponent<Renderer>().material = world1Cylinder1;
            cylinder4.GetComponent<Renderer>().material = world1Cylinder2;
            cylinder5.GetComponent<Renderer>().material = world1Cylinder1;
            cylinder6.GetComponent<Renderer>().material = world1Cylinder2;
        }
        else if (skinState == 1)
        {
            skin1.SetActive(false);
            skin2.SetActive(true);
            skin3.SetActive(false);
            skin4.SetActive(false);
            skin5.SetActive(false);
            skin6.SetActive(false);
            skin7.SetActive(false);
            skin8.SetActive(false);
            skin9.SetActive(false);
            skin10.SetActive(false);
            skin11.SetActive(false);
            skin12.SetActive(false);

            speed = 0.8f;
            PlayerPrefs.SetFloat("speed", speed);
            maxPostemp = 200;
            PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
            PlayerPrefs.SetInt("easy", 40);
            PlayerPrefs.SetInt("medium", 80);
            PlayerPrefs.SetInt("divider", 30);

            sky.GetComponent<Renderer>().material = sky1;
            cloud1.GetComponent<Renderer>().material = matCloud1;
            cloud2.GetComponent<Renderer>().material = matCloud1;
            cloud3.GetComponent<Renderer>().material = matCloud1;
            cloud4.GetComponent<Renderer>().material = matCloud1;
            cloud5.GetComponent<Renderer>().material = matCloud1;
            cloud6.GetComponent<Renderer>().material = matCloud1;
            cylinder1.GetComponent<Renderer>().material = world1Cylinder1;
            cylinder2.GetComponent<Renderer>().material = world1Cylinder2;
            cylinder3.GetComponent<Renderer>().material = world1Cylinder1;
            cylinder4.GetComponent<Renderer>().material = world1Cylinder2;
            cylinder5.GetComponent<Renderer>().material = world1Cylinder1;
            cylinder6.GetComponent<Renderer>().material = world1Cylinder2;
        }
        else if (skinState == 2)
        {
            skin1.SetActive(false);
            skin2.SetActive(false);
            skin3.SetActive(true);
            skin4.SetActive(false);
            skin5.SetActive(false);
            skin6.SetActive(false);
            skin7.SetActive(false);
            skin8.SetActive(false);
            skin9.SetActive(false);
            skin10.SetActive(false);
            skin11.SetActive(false);
            skin12.SetActive(false);

            speed = 0.9f;
            PlayerPrefs.SetFloat("speed", speed);
            maxPostemp = 250;
            PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
            PlayerPrefs.SetInt("easy", 45);
            PlayerPrefs.SetInt("medium", 70);
            PlayerPrefs.SetInt("divider", 25);

            sky.GetComponent<Renderer>().material = sky1;
            cloud1.GetComponent<Renderer>().material = matCloud1;
            cloud2.GetComponent<Renderer>().material = matCloud1;
            cloud3.GetComponent<Renderer>().material = matCloud1;
            cloud4.GetComponent<Renderer>().material = matCloud1;
            cloud5.GetComponent<Renderer>().material = matCloud1;
            cloud6.GetComponent<Renderer>().material = matCloud1;
            cylinder1.GetComponent<Renderer>().material = world1Cylinder1;
            cylinder2.GetComponent<Renderer>().material = world1Cylinder2;
            cylinder3.GetComponent<Renderer>().material = world1Cylinder1;
            cylinder4.GetComponent<Renderer>().material = world1Cylinder2;
            cylinder5.GetComponent<Renderer>().material = world1Cylinder1;
            cylinder6.GetComponent<Renderer>().material = world1Cylinder2;
        }
        else if (skinState == 3)
        {
            skin1.SetActive(false);
            skin2.SetActive(false);
            skin3.SetActive(false);
            skin4.SetActive(true);
            skin5.SetActive(false);
            skin6.SetActive(false);
            skin7.SetActive(false);
            skin8.SetActive(false);
            skin9.SetActive(false);
            skin10.SetActive(false);
            skin11.SetActive(false);
            skin12.SetActive(false);

            speed = 1f;
            PlayerPrefs.SetFloat("speed", speed);
            maxPostemp = 300;
            PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
            PlayerPrefs.SetInt("easy", 40);
            PlayerPrefs.SetInt("medium", 70);
            PlayerPrefs.SetInt("divider", 25);

            sky.GetComponent<Renderer>().material = sky2;
            cloud1.GetComponent<Renderer>().material = matCloud2;
            cloud2.GetComponent<Renderer>().material = matCloud2;
            cloud3.GetComponent<Renderer>().material = matCloud2;
            cloud4.GetComponent<Renderer>().material = matCloud2;
            cloud5.GetComponent<Renderer>().material = matCloud2;
            cloud6.GetComponent<Renderer>().material = matCloud2;
            cylinder1.GetComponent<Renderer>().material = world2Cylinder1;
            cylinder2.GetComponent<Renderer>().material = world2Cylinder2;
            cylinder3.GetComponent<Renderer>().material = world2Cylinder1;
            cylinder4.GetComponent<Renderer>().material = world2Cylinder2;
            cylinder5.GetComponent<Renderer>().material = world2Cylinder1;
            cylinder6.GetComponent<Renderer>().material = world2Cylinder2;
        }
        else if (skinState == 4)
        {
            skin1.SetActive(false);
            skin2.SetActive(false);
            skin3.SetActive(false);
            skin4.SetActive(false);
            skin5.SetActive(true);
            skin6.SetActive(false);
            skin7.SetActive(false);
            skin8.SetActive(false);
            skin9.SetActive(false);
            skin10.SetActive(false);
            skin11.SetActive(false);
            skin12.SetActive(false);

            speed = 1.1f;
            PlayerPrefs.SetFloat("speed", speed);
            maxPostemp = 350;
            PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
            PlayerPrefs.SetInt("easy", 35);
            PlayerPrefs.SetInt("medium", 70);
            PlayerPrefs.SetInt("divider", 20);

            sky.GetComponent<Renderer>().material = sky2;
            cloud1.GetComponent<Renderer>().material = matCloud2;
            cloud2.GetComponent<Renderer>().material = matCloud2;
            cloud3.GetComponent<Renderer>().material = matCloud2;
            cloud4.GetComponent<Renderer>().material = matCloud2;
            cloud5.GetComponent<Renderer>().material = matCloud2;
            cloud6.GetComponent<Renderer>().material = matCloud2;
            cylinder1.GetComponent<Renderer>().material = world2Cylinder1;
            cylinder2.GetComponent<Renderer>().material = world2Cylinder2;
            cylinder3.GetComponent<Renderer>().material = world2Cylinder1;
            cylinder4.GetComponent<Renderer>().material = world2Cylinder2;
            cylinder5.GetComponent<Renderer>().material = world2Cylinder1;
            cylinder6.GetComponent<Renderer>().material = world2Cylinder2;
        }
        else if (skinState == 5)
        {
            skin1.SetActive(false);
            skin2.SetActive(false);
            skin3.SetActive(false);
            skin4.SetActive(false);
            skin5.SetActive(false);
            skin6.SetActive(true);
            skin7.SetActive(false);
            skin8.SetActive(false);
            skin9.SetActive(false);
            skin10.SetActive(false);
            skin11.SetActive(false);
            skin12.SetActive(false);

            speed = 1.2f;
            PlayerPrefs.SetFloat("speed", speed);
            maxPostemp = 400;
            PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
            PlayerPrefs.SetInt("easy", 33);
            PlayerPrefs.SetInt("medium", 65);
            PlayerPrefs.SetInt("divider", 15);

            sky.GetComponent<Renderer>().material = sky2;
            cloud1.GetComponent<Renderer>().material = matCloud2;
            cloud2.GetComponent<Renderer>().material = matCloud2;
            cloud3.GetComponent<Renderer>().material = matCloud2;
            cloud4.GetComponent<Renderer>().material = matCloud2;
            cloud5.GetComponent<Renderer>().material = matCloud2;
            cloud6.GetComponent<Renderer>().material = matCloud2;
            cylinder1.GetComponent<Renderer>().material = world2Cylinder1;
            cylinder2.GetComponent<Renderer>().material = world2Cylinder2;
            cylinder3.GetComponent<Renderer>().material = world2Cylinder1;
            cylinder4.GetComponent<Renderer>().material = world2Cylinder2;
            cylinder5.GetComponent<Renderer>().material = world2Cylinder1;
            cylinder6.GetComponent<Renderer>().material = world2Cylinder2;
        }
        else if (skinState == 6)
        {
            skin1.SetActive(false);
            skin2.SetActive(false);
            skin3.SetActive(false);
            skin4.SetActive(false);
            skin5.SetActive(false);
            skin6.SetActive(false);
            skin7.SetActive(true);
            skin8.SetActive(false);
            skin9.SetActive(false);
            skin10.SetActive(false);
            skin11.SetActive(false);
            skin12.SetActive(false);

            speed = 1.3f;
            PlayerPrefs.SetFloat("speed", speed);
            maxPostemp = 450;
            PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
            PlayerPrefs.SetInt("easy", 20);
            PlayerPrefs.SetInt("medium", 60);
            PlayerPrefs.SetInt("divider", 10);

            sky.GetComponent<Renderer>().material = sky3;
            cloud1.GetComponent<Renderer>().material = matCloud3;
            cloud2.GetComponent<Renderer>().material = matCloud3;
            cloud3.GetComponent<Renderer>().material = matCloud3;
            cloud4.GetComponent<Renderer>().material = matCloud3;
            cloud5.GetComponent<Renderer>().material = matCloud3;
            cloud6.GetComponent<Renderer>().material = matCloud3;
            cylinder1.GetComponent<Renderer>().material = world3Cylinder1;
            cylinder2.GetComponent<Renderer>().material = world3Cylinder2;
            cylinder3.GetComponent<Renderer>().material = world3Cylinder1;
            cylinder4.GetComponent<Renderer>().material = world3Cylinder2;
            cylinder5.GetComponent<Renderer>().material = world3Cylinder1;
            cylinder6.GetComponent<Renderer>().material = world3Cylinder2;

        }
        else if (skinState == 7)
        {
            skin1.SetActive(false);
            skin2.SetActive(false);
            skin3.SetActive(false);
            skin4.SetActive(false);
            skin5.SetActive(false);
            skin6.SetActive(false);
            skin7.SetActive(false);
            skin8.SetActive(true);
            skin9.SetActive(false);
            skin10.SetActive(false);
            skin11.SetActive(false);
            skin12.SetActive(false);

            speed = 1.4f;
            PlayerPrefs.SetFloat("speed", speed);
            maxPostemp = 500;
            PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
            PlayerPrefs.SetInt("easy", 34);
            PlayerPrefs.SetInt("medium", 66);
            PlayerPrefs.SetInt("divider", 10);

            sky.GetComponent<Renderer>().material = sky3;
            cloud1.GetComponent<Renderer>().material = matCloud3;
            cloud2.GetComponent<Renderer>().material = matCloud3;
            cloud3.GetComponent<Renderer>().material = matCloud3;
            cloud4.GetComponent<Renderer>().material = matCloud3;
            cloud5.GetComponent<Renderer>().material = matCloud3;
            cloud6.GetComponent<Renderer>().material = matCloud3;
            cylinder1.GetComponent<Renderer>().material = world3Cylinder1;
            cylinder2.GetComponent<Renderer>().material = world3Cylinder2;
            cylinder3.GetComponent<Renderer>().material = world3Cylinder1;
            cylinder4.GetComponent<Renderer>().material = world3Cylinder2;
            cylinder5.GetComponent<Renderer>().material = world3Cylinder1;
            cylinder6.GetComponent<Renderer>().material = world3Cylinder2;

        }
        else if (skinState == 8)
        {
            skin1.SetActive(false);
            skin2.SetActive(false);
            skin3.SetActive(false);
            skin4.SetActive(false);
            skin5.SetActive(false);
            skin6.SetActive(false);
            skin7.SetActive(false);
            skin8.SetActive(false);
            skin9.SetActive(true);
            skin10.SetActive(false);
            skin11.SetActive(false);
            skin12.SetActive(false);

            speed = 1.5f;
            PlayerPrefs.SetFloat("speed", speed);
            maxPostemp = 550;
            PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
            PlayerPrefs.SetInt("easy", 33);
            PlayerPrefs.SetInt("medium", 67);
            PlayerPrefs.SetInt("divider", 5);

            sky.GetComponent<Renderer>().material = sky3;
            cloud1.GetComponent<Renderer>().material = matCloud3;
            cloud2.GetComponent<Renderer>().material = matCloud3;
            cloud3.GetComponent<Renderer>().material = matCloud3;
            cloud4.GetComponent<Renderer>().material = matCloud3;
            cloud5.GetComponent<Renderer>().material = matCloud3;
            cloud6.GetComponent<Renderer>().material = matCloud3;
            cylinder1.GetComponent<Renderer>().material = world3Cylinder1;
            cylinder2.GetComponent<Renderer>().material = world3Cylinder2;
            cylinder3.GetComponent<Renderer>().material = world3Cylinder1;
            cylinder4.GetComponent<Renderer>().material = world3Cylinder2;
            cylinder5.GetComponent<Renderer>().material = world3Cylinder1;
            cylinder6.GetComponent<Renderer>().material = world3Cylinder2;
        }
        else if (skinState == 9)
        {
            skin1.SetActive(false);
            skin2.SetActive(false);
            skin3.SetActive(false);
            skin4.SetActive(false);
            skin5.SetActive(false);
            skin6.SetActive(false);
            skin7.SetActive(false);
            skin8.SetActive(false);
            skin9.SetActive(false);
            skin10.SetActive(true);
            skin11.SetActive(false);
            skin12.SetActive(false);

            speed = 1.6f;
            PlayerPrefs.SetFloat("speed", speed);
            maxPostemp = 600;
            PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
            PlayerPrefs.SetInt("easy", 33);
            PlayerPrefs.SetInt("medium", 66);
            PlayerPrefs.SetInt("divider", 5);

            sky.GetComponent<Renderer>().material = sky4;
            cloud1.GetComponent<Renderer>().material = matCloud4;
            cloud2.GetComponent<Renderer>().material = matCloud4;
            cloud3.GetComponent<Renderer>().material = matCloud4;
            cloud4.GetComponent<Renderer>().material = matCloud4;
            cloud5.GetComponent<Renderer>().material = matCloud4;
            cloud6.GetComponent<Renderer>().material = matCloud4;
            cylinder1.GetComponent<Renderer>().material = world4Cylinder1;
            cylinder2.GetComponent<Renderer>().material = world4Cylinder2;
            cylinder3.GetComponent<Renderer>().material = world4Cylinder1;
            cylinder4.GetComponent<Renderer>().material = world4Cylinder2;
            cylinder5.GetComponent<Renderer>().material = world4Cylinder1;
            cylinder6.GetComponent<Renderer>().material = world4Cylinder2;

        }
        else if (skinState == 10)
        {
            skin1.SetActive(false);
            skin2.SetActive(false);
            skin3.SetActive(false);
            skin4.SetActive(false);
            skin5.SetActive(false);
            skin6.SetActive(false);
            skin7.SetActive(false);
            skin8.SetActive(false);
            skin9.SetActive(false);
            skin10.SetActive(false);
            skin11.SetActive(true);
            skin12.SetActive(false);

            speed = 1.75f;
            PlayerPrefs.SetFloat("speed", speed);
            maxPostemp = 650;
            PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
            PlayerPrefs.SetInt("easy", 30);
            PlayerPrefs.SetInt("medium", 60);
            PlayerPrefs.SetInt("divider", 5);

            sky.GetComponent<Renderer>().material = sky4;
            cloud1.GetComponent<Renderer>().material = matCloud4;
            cloud2.GetComponent<Renderer>().material = matCloud4;
            cloud3.GetComponent<Renderer>().material = matCloud4;
            cloud4.GetComponent<Renderer>().material = matCloud4;
            cloud5.GetComponent<Renderer>().material = matCloud4;
            cloud6.GetComponent<Renderer>().material = matCloud4;
            cylinder1.GetComponent<Renderer>().material = world4Cylinder1;
            cylinder2.GetComponent<Renderer>().material = world4Cylinder2;
            cylinder3.GetComponent<Renderer>().material = world4Cylinder1;
            cylinder4.GetComponent<Renderer>().material = world4Cylinder2;
            cylinder5.GetComponent<Renderer>().material = world4Cylinder1;
            cylinder6.GetComponent<Renderer>().material = world4Cylinder2;
        }
        else if (skinState == 11)
        {
            skin1.SetActive(false);
            skin2.SetActive(false);
            skin3.SetActive(false);
            skin4.SetActive(false);
            skin5.SetActive(false);
            skin6.SetActive(false);
            skin7.SetActive(false);
            skin8.SetActive(false);
            skin9.SetActive(false);
            skin10.SetActive(false);
            skin11.SetActive(false);
            skin12.SetActive(true);

            speed = 2f;
            PlayerPrefs.SetFloat("speed", speed);
            maxPostemp = 700;
            PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
            PlayerPrefs.SetInt("easy", 25);
            PlayerPrefs.SetInt("medium", 50);
            PlayerPrefs.SetInt("divider", 1);

            sky.GetComponent<Renderer>().material = sky4;
            cloud1.GetComponent<Renderer>().material = matCloud4;
            cloud2.GetComponent<Renderer>().material = matCloud4;
            cloud3.GetComponent<Renderer>().material = matCloud4;
            cloud4.GetComponent<Renderer>().material = matCloud4;
            cloud5.GetComponent<Renderer>().material = matCloud4;
            cloud6.GetComponent<Renderer>().material = matCloud4;
            cylinder1.GetComponent<Renderer>().material = world4Cylinder1;
            cylinder2.GetComponent<Renderer>().material = world4Cylinder2;
            cylinder3.GetComponent<Renderer>().material = world4Cylinder1;
            cylinder4.GetComponent<Renderer>().material = world4Cylinder2;
            cylinder5.GetComponent<Renderer>().material = world4Cylinder1;
            cylinder6.GetComponent<Renderer>().material = world4Cylinder2;


        }
    }
}
