using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChanger : MonoBehaviour
{
    public GameObject cylinder1;
    public GameObject cylinder2;
    public GameObject cylinder3;
    public GameObject cylinder4;
    public GameObject cylinder5;
    public GameObject cylinder6;

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
    public Material world6Cylinder1;
    public Material world6Cylinder2;
    public Material world7Cylinder1;
    public Material world7Cylinder2;
    public Material matCloud1;
    public Material matCloud2;
    public Material matCloud3;
    public Material matCloud4;
    public Material matCloud5;
    public Material matCloud6;
    public Material matCloud7;
    public Material sky1;
    public Material sky2;
    public Material sky3;
    public Material sky4;
    public Material sky5;
    public Material sky6;
    public Material sky7;
    public Material spiral1;
    public Material spiral2;
    public Material spiral3;
    public Material spiral4;
    public Material spiral5;
    public Material spiral6;
    public Material spiral7;

    float speed;
    float maxPostemp;

    public void level1()
    {
        speed = 1f;
        PlayerPrefs.SetFloat("speed", speed);
        maxPostemp = 200f;
        PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
        PlayerPrefs.SetInt("easy", 75);
        PlayerPrefs.SetInt("medium", 95);
        PlayerPrefs.SetInt("divider", 100);

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

    public void level2()
    {
        speed = 1.1f;
        PlayerPrefs.SetFloat("speed", speed);
        maxPostemp = 200;
        PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
        PlayerPrefs.SetInt("easy", 75);
        PlayerPrefs.SetInt("medium", 90);
        PlayerPrefs.SetInt("divider", 90);

        sky.GetComponent<Renderer>().material = sky1;
        cloud1.GetComponent<Renderer>().material = matCloud1;
        cloud2.GetComponent<Renderer>().material = matCloud1;
        cloud3.GetComponent<Renderer>().material = matCloud1;
        cloud4.GetComponent<Renderer>().material = matCloud1;
        cloud5.GetComponent<Renderer>().material = matCloud1;
        cloud6.GetComponent<Renderer>().material = matCloud1;
        cylinder1.GetComponent<Renderer>().material = spiral1;
        cylinder2.GetComponent<Renderer>().material = spiral1;
        cylinder3.GetComponent<Renderer>().material = spiral1;
        cylinder4.GetComponent<Renderer>().material = spiral1;
        cylinder5.GetComponent<Renderer>().material = spiral1;
        cylinder6.GetComponent<Renderer>().material = spiral1;
    }

    public void level3()
    {
        speed = 1.2f;
        PlayerPrefs.SetFloat("speed", speed);
        maxPostemp = 250;
        PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
        PlayerPrefs.SetInt("easy", 70);
        PlayerPrefs.SetInt("medium", 90);
        PlayerPrefs.SetInt("divider", 80);

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

    public void level4()
    {
        speed = 1.3f;
        PlayerPrefs.SetFloat("speed", speed);
        maxPostemp = 300;
        PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
        PlayerPrefs.SetInt("easy", 60);
        PlayerPrefs.SetInt("medium", 90);
        PlayerPrefs.SetInt("divider", 75);

        sky.GetComponent<Renderer>().material = sky2;
        cloud1.GetComponent<Renderer>().material = matCloud2;
        cloud2.GetComponent<Renderer>().material = matCloud2;
        cloud3.GetComponent<Renderer>().material = matCloud2;
        cloud4.GetComponent<Renderer>().material = matCloud2;
        cloud5.GetComponent<Renderer>().material = matCloud2;
        cloud6.GetComponent<Renderer>().material = matCloud2;
        cylinder1.GetComponent<Renderer>().material = spiral2;
        cylinder2.GetComponent<Renderer>().material = spiral2;
        cylinder3.GetComponent<Renderer>().material = spiral2;
        cylinder4.GetComponent<Renderer>().material = spiral2;
        cylinder5.GetComponent<Renderer>().material = spiral2;
        cylinder6.GetComponent<Renderer>().material = spiral2;
    }

    public void level5()
    {
        speed = 1.4f;
        PlayerPrefs.SetFloat("speed", speed);
        maxPostemp = 350;
        PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
        PlayerPrefs.SetInt("easy", 55);
        PlayerPrefs.SetInt("medium", 90);
        PlayerPrefs.SetInt("divider", 60);

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

    public void level6()
    {
        speed = 1.5f;
        PlayerPrefs.SetFloat("speed", speed);
        maxPostemp = 400;
        PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
        PlayerPrefs.SetInt("easy", 55);
        PlayerPrefs.SetInt("medium", 90);
        PlayerPrefs.SetInt("divider", 55);

        sky.GetComponent<Renderer>().material = sky3;
        cloud1.GetComponent<Renderer>().material = matCloud3;
        cloud2.GetComponent<Renderer>().material = matCloud3;
        cloud3.GetComponent<Renderer>().material = matCloud3;
        cloud4.GetComponent<Renderer>().material = matCloud3;
        cloud5.GetComponent<Renderer>().material = matCloud3;
        cloud6.GetComponent<Renderer>().material = matCloud3;
        cylinder1.GetComponent<Renderer>().material = spiral3;
        cylinder2.GetComponent<Renderer>().material = spiral3;
        cylinder3.GetComponent<Renderer>().material = spiral3;
        cylinder4.GetComponent<Renderer>().material = spiral3;
        cylinder5.GetComponent<Renderer>().material = spiral3;
        cylinder6.GetComponent<Renderer>().material = spiral3;
    }

    public void level7()
    {
        speed = 1.6f;
        PlayerPrefs.SetFloat("speed", speed);
        maxPostemp = 450;
        PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
        PlayerPrefs.SetInt("easy", 50);
        PlayerPrefs.SetInt("medium", 90);
        PlayerPrefs.SetInt("divider", 50);

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

    public void level8()
    {
        speed = 1.7f;
        PlayerPrefs.SetFloat("speed", speed);
        maxPostemp = 500;
        PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
        PlayerPrefs.SetInt("easy", 50);
        PlayerPrefs.SetInt("medium", 85);
        PlayerPrefs.SetInt("divider", 45);

        sky.GetComponent<Renderer>().material = sky4;
        cloud1.GetComponent<Renderer>().material = matCloud4;
        cloud2.GetComponent<Renderer>().material = matCloud4;
        cloud3.GetComponent<Renderer>().material = matCloud4;
        cloud4.GetComponent<Renderer>().material = matCloud4;
        cloud5.GetComponent<Renderer>().material = matCloud4;
        cloud6.GetComponent<Renderer>().material = matCloud4;
        cylinder1.GetComponent<Renderer>().material = spiral4;
        cylinder2.GetComponent<Renderer>().material = spiral4;
        cylinder3.GetComponent<Renderer>().material = spiral4;
        cylinder4.GetComponent<Renderer>().material = spiral4;
        cylinder5.GetComponent<Renderer>().material = spiral4;
        cylinder6.GetComponent<Renderer>().material = spiral4;
    }

    public void level9()
    {
        speed = 1.8f;
        PlayerPrefs.SetFloat("speed", speed);
        maxPostemp = 550;
        PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
        PlayerPrefs.SetInt("easy", 50);
        PlayerPrefs.SetInt("medium", 80);
        PlayerPrefs.SetInt("divider", 40);

        sky.GetComponent<Renderer>().material = sky5;
        cloud1.GetComponent<Renderer>().material = matCloud5;
        cloud2.GetComponent<Renderer>().material = matCloud5;
        cloud3.GetComponent<Renderer>().material = matCloud5;
        cloud4.GetComponent<Renderer>().material = matCloud5;
        cloud5.GetComponent<Renderer>().material = matCloud5;
        cloud6.GetComponent<Renderer>().material = matCloud5;
        cylinder1.GetComponent<Renderer>().material = world5Cylinder1;
        cylinder2.GetComponent<Renderer>().material = world5Cylinder2;
        cylinder3.GetComponent<Renderer>().material = world5Cylinder1;
        cylinder4.GetComponent<Renderer>().material = world5Cylinder2;
        cylinder5.GetComponent<Renderer>().material = world5Cylinder1;
        cylinder6.GetComponent<Renderer>().material = world5Cylinder2;
    }

    public void level10()
    {
        speed = 1.9f;
        PlayerPrefs.SetFloat("speed", speed);
        maxPostemp = 600;
        PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
        PlayerPrefs.SetInt("easy", 40);
        PlayerPrefs.SetInt("medium", 80);
        PlayerPrefs.SetInt("divider", 35);

        sky.GetComponent<Renderer>().material = sky5;
        cloud1.GetComponent<Renderer>().material = matCloud5;
        cloud2.GetComponent<Renderer>().material = matCloud5;
        cloud3.GetComponent<Renderer>().material = matCloud5;
        cloud4.GetComponent<Renderer>().material = matCloud5;
        cloud5.GetComponent<Renderer>().material = matCloud5;
        cloud6.GetComponent<Renderer>().material = matCloud5;
        cylinder1.GetComponent<Renderer>().material = spiral5;
        cylinder2.GetComponent<Renderer>().material = spiral5;
        cylinder3.GetComponent<Renderer>().material = spiral5;
        cylinder4.GetComponent<Renderer>().material = spiral5;
        cylinder5.GetComponent<Renderer>().material = spiral5;
        cylinder6.GetComponent<Renderer>().material = spiral5;
    }

    public void level11()
    {
        speed = 2f;
        PlayerPrefs.SetFloat("speed", speed);
        maxPostemp = 650;
        PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
        PlayerPrefs.SetInt("easy", 30);
        PlayerPrefs.SetInt("medium", 80);
        PlayerPrefs.SetInt("divider", 30);

        sky.GetComponent<Renderer>().material = sky6;
        cloud1.GetComponent<Renderer>().material = matCloud6;
        cloud2.GetComponent<Renderer>().material = matCloud6;
        cloud3.GetComponent<Renderer>().material = matCloud6;
        cloud4.GetComponent<Renderer>().material = matCloud6;
        cloud5.GetComponent<Renderer>().material = matCloud6;
        cloud6.GetComponent<Renderer>().material = matCloud6;
        cylinder1.GetComponent<Renderer>().material = world6Cylinder1;
        cylinder2.GetComponent<Renderer>().material = world6Cylinder2;
        cylinder3.GetComponent<Renderer>().material = world6Cylinder1;
        cylinder4.GetComponent<Renderer>().material = world6Cylinder2;
        cylinder5.GetComponent<Renderer>().material = world6Cylinder1;
        cylinder6.GetComponent<Renderer>().material = world6Cylinder2;
    }

    public void level12()
    {
        speed = 2.1f;
        PlayerPrefs.SetFloat("speed", speed);
        maxPostemp = 700;
        PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
        PlayerPrefs.SetInt("easy", 20);
        PlayerPrefs.SetInt("medium", 80);
        PlayerPrefs.SetInt("divider", 25);

        sky.GetComponent<Renderer>().material = sky6;
        cloud1.GetComponent<Renderer>().material = matCloud6;
        cloud2.GetComponent<Renderer>().material = matCloud6;
        cloud3.GetComponent<Renderer>().material = matCloud6;
        cloud4.GetComponent<Renderer>().material = matCloud6;
        cloud5.GetComponent<Renderer>().material = matCloud6;
        cloud6.GetComponent<Renderer>().material = matCloud6;
        cylinder1.GetComponent<Renderer>().material = world6Cylinder1;
        cylinder2.GetComponent<Renderer>().material = world6Cylinder2;
        cylinder3.GetComponent<Renderer>().material = world6Cylinder1;
        cylinder4.GetComponent<Renderer>().material = world6Cylinder2;
        cylinder5.GetComponent<Renderer>().material = world6Cylinder1;
        cylinder6.GetComponent<Renderer>().material = world6Cylinder2;
    }

    public void level13()
    {
        speed = 2.2f;
        PlayerPrefs.SetFloat("speed", speed);
        maxPostemp = 700;
        PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
        PlayerPrefs.SetInt("easy", 10);
        PlayerPrefs.SetInt("medium", 80);
        PlayerPrefs.SetInt("divider", 20);

        sky.GetComponent<Renderer>().material = sky6;
        cloud1.GetComponent<Renderer>().material = matCloud6;
        cloud2.GetComponent<Renderer>().material = matCloud6;
        cloud3.GetComponent<Renderer>().material = matCloud6;
        cloud4.GetComponent<Renderer>().material = matCloud6;
        cloud5.GetComponent<Renderer>().material = matCloud6;
        cloud6.GetComponent<Renderer>().material = matCloud6;
        cylinder1.GetComponent<Renderer>().material = spiral6;
        cylinder2.GetComponent<Renderer>().material = spiral6;
        cylinder3.GetComponent<Renderer>().material = spiral6;
        cylinder4.GetComponent<Renderer>().material = spiral6;
        cylinder5.GetComponent<Renderer>().material = spiral6;
        cylinder6.GetComponent<Renderer>().material = spiral6;
    }

    public void level14()
    {
        speed = 2.3f;
        PlayerPrefs.SetFloat("speed", speed);
        maxPostemp = 700;
        PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
        PlayerPrefs.SetInt("easy", 30);
        PlayerPrefs.SetInt("medium", 75);
        PlayerPrefs.SetInt("divider", 20);

        sky.GetComponent<Renderer>().material = sky7;
        cloud1.GetComponent<Renderer>().material = matCloud7;
        cloud2.GetComponent<Renderer>().material = matCloud7;
        cloud3.GetComponent<Renderer>().material = matCloud7;
        cloud4.GetComponent<Renderer>().material = matCloud7;
        cloud5.GetComponent<Renderer>().material = matCloud7;
        cloud6.GetComponent<Renderer>().material = matCloud7;
        cylinder1.GetComponent<Renderer>().material = world7Cylinder1;
        cylinder2.GetComponent<Renderer>().material = world7Cylinder2;
        cylinder3.GetComponent<Renderer>().material = world7Cylinder1;
        cylinder4.GetComponent<Renderer>().material = world7Cylinder2;
        cylinder5.GetComponent<Renderer>().material = world7Cylinder1;
        cylinder6.GetComponent<Renderer>().material = world7Cylinder2;
    }

    public void level15()
    {
        speed = 2.4f;
        PlayerPrefs.SetFloat("speed", speed);
        maxPostemp = 1000;
        PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
        PlayerPrefs.SetInt("easy", 45);
        PlayerPrefs.SetInt("medium", 75);
        PlayerPrefs.SetInt("divider", 15);

        sky.GetComponent<Renderer>().material = sky7;
        cloud1.GetComponent<Renderer>().material = matCloud7;
        cloud2.GetComponent<Renderer>().material = matCloud7;
        cloud3.GetComponent<Renderer>().material = matCloud7;
        cloud4.GetComponent<Renderer>().material = matCloud7;
        cloud5.GetComponent<Renderer>().material = matCloud7;
        cloud6.GetComponent<Renderer>().material = matCloud7;
        cylinder1.GetComponent<Renderer>().material = world7Cylinder1;
        cylinder2.GetComponent<Renderer>().material = world7Cylinder2;
        cylinder3.GetComponent<Renderer>().material = world7Cylinder1;
        cylinder4.GetComponent<Renderer>().material = world7Cylinder2;
        cylinder5.GetComponent<Renderer>().material = world7Cylinder1;
        cylinder6.GetComponent<Renderer>().material = world7Cylinder2;
    }

    public void level16()
    {
        speed = 2.5f;
        PlayerPrefs.SetFloat("speed", speed);
        maxPostemp = 1000;
        PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
        PlayerPrefs.SetInt("easy", 40);
        PlayerPrefs.SetInt("medium", 70);
        PlayerPrefs.SetInt("divider", 10);

        sky.GetComponent<Renderer>().material = sky7;
        cloud1.GetComponent<Renderer>().material = matCloud7;
        cloud2.GetComponent<Renderer>().material = matCloud7;
        cloud3.GetComponent<Renderer>().material = matCloud7;
        cloud4.GetComponent<Renderer>().material = matCloud7;
        cloud5.GetComponent<Renderer>().material = matCloud7;
        cloud6.GetComponent<Renderer>().material = matCloud7;
        cylinder1.GetComponent<Renderer>().material = spiral7;
        cylinder2.GetComponent<Renderer>().material = spiral7;
        cylinder3.GetComponent<Renderer>().material = spiral7;
        cylinder4.GetComponent<Renderer>().material = spiral7;
        cylinder5.GetComponent<Renderer>().material = spiral7;
        cylinder6.GetComponent<Renderer>().material = spiral7;

    }

    public void level17()
    {
        speed = 1f;
        PlayerPrefs.SetFloat("speed", speed);
        maxPostemp = 1000;
        PlayerPrefs.SetFloat("maxPostemp", maxPostemp);
        PlayerPrefs.SetInt("easy", 25);
        PlayerPrefs.SetInt("medium", 75);
        PlayerPrefs.SetInt("divider", 50);

        sky.GetComponent<Renderer>().material = sky5;
        cloud1.GetComponent<Renderer>().material = matCloud5;
        cloud2.GetComponent<Renderer>().material = matCloud4;
        cloud3.GetComponent<Renderer>().material = matCloud3;
        cloud4.GetComponent<Renderer>().material = matCloud2;
        cloud5.GetComponent<Renderer>().material = matCloud1;
        cloud6.GetComponent<Renderer>().material = matCloud4;
        cylinder1.GetComponent<Renderer>().material = world1Cylinder1;
        cylinder2.GetComponent<Renderer>().material = world2Cylinder2;
        cylinder3.GetComponent<Renderer>().material = world3Cylinder1;
        cylinder4.GetComponent<Renderer>().material = world4Cylinder2;
        cylinder5.GetComponent<Renderer>().material = world5Cylinder1;
        cylinder6.GetComponent<Renderer>().material = world5Cylinder2;

    }
}
