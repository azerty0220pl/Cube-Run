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
    public Material world5Cylinder1;
    public Material world5Cylinder2;
    public Material matCloud1;
    public Material matCloud2;
    public Material matCloud3;
    public Material matCloud4;
    public Material matCloud5;
    public Material sky1;
    public Material sky2;
    public Material sky3;
    public Material sky4;
    public Material sky5;

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
    public GameObject skin13;
    public GameObject skin14;
    public GameObject skin15;
    public GameObject skin16;

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
    int prize13;
    int prize14;
    int prize15;
    int prize16;

    int skinState;
    int maxSkin;
    int coins;
    float speed;
    float maxPostemp;

    void Start()
    {
        prize2 = 50;
        prize3 = 100;
        prize4 = 150;
        prize5 = 300;
        prize6 = 400;
        prize7 = 500;
        prize8 = 600;
        prize9 = 700;
        prize10 = 1000;
        prize11 = 1250;
        prize12 = 2000;
        prize13 = 4000;
        prize14 = 6000;
        prize15 = 10000;
        prize16 = 100000;

        skinState = PlayerPrefs.GetInt("skinState");
        maxSkin = PlayerPrefs.GetInt("maxSkin");

        LoadSkin();
    }

    public void reset()
    {
        PlayerPrefs.SetInt("skinState", 0);
        PlayerPrefs.SetInt("maxSkin", 0);
        PlayerPrefs.SetInt("coins", 0);
        PlayerPrefs.SetInt("premium", 0);
        Start();
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
                left = prize4 - coins;
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
        else if (maxSkin == 11)
        {
            if (coins >= prize13 || PlayerPrefs.GetInt("premium") == 1)
            {
                maxSkin = maxSkin + 1;
                PlayerPrefs.SetInt("maxSkin", maxSkin);
                moveRight();
                coins = coins - prize13;
                PlayerPrefs.SetInt("coins", coins);
            }
            else
            {
                noMoney.SetActive(true);
                moneyText = noMoneyText.GetComponent<Text>();
                left = prize13 - coins;
                moneyText.text = "You need " + left + " coins more.";
            }
        }
        else if (maxSkin == 12)
        {
            if (coins >= prize14 || PlayerPrefs.GetInt("premium") == 1)
            {
                maxSkin = maxSkin + 1;
                PlayerPrefs.SetInt("maxSkin", maxSkin);
                moveRight();
                coins = coins - prize14;
                PlayerPrefs.SetInt("coins", coins);
            }
            else
            {
                noMoney.SetActive(true);
                moneyText = noMoneyText.GetComponent<Text>();
                left = prize14 - coins;
                moneyText.text = "You need " + left + " coins more.";
            }
        }
        else if (maxSkin == 13)
        {
            if (coins >= prize15 || PlayerPrefs.GetInt("premium") == 1)
            {
                maxSkin = maxSkin + 1;
                PlayerPrefs.SetInt("maxSkin", maxSkin);
                moveRight();
                coins = coins - prize15;
                PlayerPrefs.SetInt("coins", coins);
            }
            else
            {
                noMoney.SetActive(true);
                moneyText = noMoneyText.GetComponent<Text>();
                left = prize15 - coins;
                moneyText.text = "You need " + left + " coins more.";
            }
        }
        else if (maxSkin == 14)
        {
            if (coins >= prize16 || PlayerPrefs.GetInt("premium") == 1)
            {
                maxSkin = maxSkin + 1;
                PlayerPrefs.SetInt("maxSkin", maxSkin);
                moveRight();
                coins = coins - prize16;
                PlayerPrefs.SetInt("coins", coins);
            }
            else
            {
                noMoney.SetActive(true);
                moneyText = noMoneyText.GetComponent<Text>();
                left = prize16 - coins;
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
            skin13.SetActive(false);
            skin14.SetActive(false);
            skin15.SetActive(false);
            skin16.SetActive(false);
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
            skin13.SetActive(false);
            skin14.SetActive(false);
            skin15.SetActive(false);
            skin16.SetActive(false);
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
            skin13.SetActive(false);
            skin14.SetActive(false);
            skin15.SetActive(false);
            skin16.SetActive(false);
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
            skin13.SetActive(false);
            skin14.SetActive(false);
            skin15.SetActive(false);
            skin16.SetActive(false);
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
            skin13.SetActive(false);
            skin14.SetActive(false);
            skin15.SetActive(false);
            skin16.SetActive(false);
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
            skin13.SetActive(false);
            skin14.SetActive(false);
            skin15.SetActive(false);
            skin16.SetActive(false);
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
            skin13.SetActive(false);
            skin14.SetActive(false);
            skin15.SetActive(false);
            skin16.SetActive(false);
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
            skin13.SetActive(false);
            skin14.SetActive(false);
            skin15.SetActive(false);
            skin16.SetActive(false);

            

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
            skin13.SetActive(false);
            skin14.SetActive(false);
            skin15.SetActive(false);
            skin16.SetActive(false);
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
            skin13.SetActive(false);
            skin14.SetActive(false);
            skin15.SetActive(false);
            skin16.SetActive(false);
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
            skin13.SetActive(false);
            skin14.SetActive(false);
            skin15.SetActive(false);
            skin16.SetActive(false);
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
            skin13.SetActive(false);
            skin14.SetActive(false);
            skin15.SetActive(false);
            skin16.SetActive(false);
        }
        else if (skinState == 12)
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
            skin12.SetActive(false);
            skin13.SetActive(true);
            skin14.SetActive(false);
            skin15.SetActive(false);
            skin16.SetActive(false);
        }
        else if (skinState == 13)
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
            skin12.SetActive(false);
            skin13.SetActive(false);
            skin14.SetActive(true);
            skin15.SetActive(false);
            skin16.SetActive(false);
        }
        else if (skinState == 14)
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
            skin12.SetActive(false);
            skin13.SetActive(false);
            skin14.SetActive(false);
            skin15.SetActive(true);
            skin16.SetActive(false);
        }
        else if (skinState == 15)
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
            skin12.SetActive(false);
            skin13.SetActive(false);
            skin14.SetActive(false);
            skin15.SetActive(false);
            skin16.SetActive(true);
        }
        else
        {
            skinState = 0;
            LoadSkin();
        }
    }
}
