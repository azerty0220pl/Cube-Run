using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    public float points;
    public float best;
    int coins;
    public GameObject finish;
    public GameObject GamePanel;
    public GameObject coinText;
    public GameObject pointsText;
    public GameObject arcadeText;
    public GameObject bestText;
    Text coinNumber;
    Text pointsCounter;
    Text arcadeResult;
    Text bestResult;
    int arcadeMoney;
    public GameObject Right;
    public GameObject Left;
    public GameObject bar;
    public Image postemp;
    public float maxPostemp;
    public int state;
    public GameObject tip;
    public GameObject tip2;
    int tipState;
    public GameObject trigger;
    public GameObject GameOver;
    public GameObject Gameplay;
    public GameObject ArcadeEnd;
    public GameObject levelObject;
    public GameObject shopScript;
    public GameObject levelChanger;
    Text levelText;
    int level;
    //int speed;


    public int targetFrameRate = 60;

    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = targetFrameRate;
        PlayerPrefs.SetInt("state", 1);

        LoadLevel();

        tipState = PlayerPrefs.GetInt("tip");
        if (tipState == 0)
        {
            tip.SetActive(true);
            tip2.SetActive(false);
            PlayerPrefs.SetInt("tip", 1);
        }
        else if (tipState == 1)
        {
            tip.SetActive(false);
            tip2.SetActive(true);
            PlayerPrefs.SetInt("tip", 2);
        }
        else
        {
            tip.SetActive(false);
            tip2.SetActive(false);
        }

        postemp = bar.GetComponent<Image>();
        maxPostemp = 600;
        transform.position = new Vector3(0f, -20f, 39f);
        points = 0;
        coins = PlayerPrefs.GetInt("coins");
        coinNumber = coinText.GetComponent<Text>();
        coinNumber.text = "" + coins;
        PlayerPrefs.SetFloat("points", 0);
    }

    // Update is called once per frame
    void Update()
    {
        best = PlayerPrefs.GetFloat("best");
        if (PlayerPrefs.GetFloat("realPoints") > best)
        {
            PlayerPrefs.SetFloat("best", PlayerPrefs.GetFloat("realPoints"));
            //bestResult = bestText.GetComponent<Text>();
            //bestResult.text = "Best score: " + best;
        }
        bestResult = bestText.GetComponent<Text>();
        bestResult.text = "Best score: " + best;

        if (transform.position.z <= 40)
            GetComponent<Rigidbody>().useGravity = false;

        if (/*PlayerPrefs.GetInt("state") == 0 &&*/ transform.position.y < -40f)
        {
            Gameplay.SetActive(false);
            level = 0;
            maxPostemp = PlayerPrefs.GetFloat("maxPostemp");
            shopScript.GetComponent<ShopManager>().LoadSkin();
            levelText = levelObject.GetComponent<Text>();
            levelText.text = "Level " + level;
            ArcadeEnd.SetActive(true);
            arcadeResult = arcadeText.GetComponent<Text>();
            arcadeMoney = Mathf.RoundToInt(PlayerPrefs.GetFloat("realPoints") / PlayerPrefs.GetInt("divider"));
            arcadeResult.text = "Points: " + PlayerPrefs.GetFloat("realPoints") + "\n" + "Your reward: " + arcadeMoney;
            Debug.Log(PlayerPrefs.GetFloat("realPoints"));
            if (PlayerPrefs.GetFloat("realPoints") > 1500f)
            {
                PlayerPrefs.SetInt("difficulty", PlayerPrefs.GetInt("difficulty") + 1);
                Debug.Log("+ 1 level");
                Debug.Log(PlayerPrefs.GetInt("difficulty"));
            }
            if (PlayerPrefs.GetFloat("realPoints") < 500 && PlayerPrefs.GetInt("difficulty") > 1)
                PlayerPrefs.SetInt("difficulty", PlayerPrefs.GetInt("difficulty") - 1);
            LoadLevel();
            coins = coins + arcadeMoney;
            PlayerPrefs.SetInt("arcadeMoney", arcadeMoney);
            PlayerPrefs.SetInt("coins", coins);
            coinNumber = coinText.GetComponent<Text>();
            coinNumber.text = "" + coins;
            PlayerPrefs.SetInt("state", 0);
            PlayerPrefs.SetInt("state", 1);
            tipState = PlayerPrefs.GetInt("tip");
            if (tipState == 0)
            {
                tip.SetActive(true);
                tip2.SetActive(false);
                PlayerPrefs.SetInt("tip", 1);
            }
            else if (tipState == 1)
            {
                tip.SetActive(false);
                tip2.SetActive(true);
                PlayerPrefs.SetInt("tip", 2);
            }
            else
            {
                tip.SetActive(false);
                tip2.SetActive(false);
            }
        }
        //maxPostemp = PlayerPrefs.GetFloat("maxPostemp");
        coins = PlayerPrefs.GetInt("coins");
        coinNumber = coinText.GetComponent<Text>();
        coinNumber.text = "" + coins;

        if (transform.position.z >= 41 && transform.position.y == -20)
        {
            points = PlayerPrefs.GetFloat("points");
            points = points + 1;
            PlayerPrefs.SetFloat("points", points);
            pointsCounter = pointsText.GetComponent<Text>();
            pointsCounter.text = "" + points;
            if (points >= maxPostemp && trigger.activeInHierarchy == true)
            {
                //points = 0;
                //PlayerPrefs.SetFloat("points", points);
                //coins = coins + 20;
                //PlayerPrefs.SetInt("coins", coins);
                state = 0;
                PlayerPrefs.SetInt("state", state);
                maxPostemp = maxPostemp * 2.1f;
                EndLevel();
            }
        }

        postemp.fillAmount = points / maxPostemp;
        //Debug.Log("points" + points + "Max Postemp" + maxPostemp + "fill " + points / maxPostemp);
    }

    void EndLevel()
    {
        level = level + 1;
        levelText = levelObject.GetComponent<Text>();
        levelText.text = "Level " + level;
        //Debug.Log(maxPostemp * 2.25f);
        PlayerPrefs.SetFloat("speed", PlayerPrefs.GetFloat("speed") * 1.1f);
    }

    void LoadLevel()
    {
        if (PlayerPrefs.GetInt("difficulty") == 2)
        {
            levelChanger.GetComponent<LevelChanger>().level2();
        }
        else if (PlayerPrefs.GetInt("difficulty") == 3)
        {
            levelChanger.GetComponent<LevelChanger>().level3();
        }
        else if (PlayerPrefs.GetInt("difficulty") == 4)
        {
            levelChanger.GetComponent<LevelChanger>().level4();
        }
        else if (PlayerPrefs.GetInt("difficulty") == 5)
        {
            levelChanger.GetComponent<LevelChanger>().level5();
        }
        else if (PlayerPrefs.GetInt("difficulty") == 6)
        {
            levelChanger.GetComponent<LevelChanger>().level6();
        }
        else if (PlayerPrefs.GetInt("difficulty") == 7)
        {
            levelChanger.GetComponent<LevelChanger>().level7();
        }
        else if (PlayerPrefs.GetInt("difficulty") == 8)
        {
            levelChanger.GetComponent<LevelChanger>().level8();
        }
        else if (PlayerPrefs.GetInt("difficulty") == 1)
        {
            levelChanger.GetComponent<LevelChanger>().level1();
        }
        else if (PlayerPrefs.GetInt("difficulty") == 9)
        {
            levelChanger.GetComponent<LevelChanger>().level9();
        }
        else if (PlayerPrefs.GetInt("difficulty") == 10)
        {
            levelChanger.GetComponent<LevelChanger>().level10();
        }
        else if (PlayerPrefs.GetInt("difficulty") == 11)
        {
            levelChanger.GetComponent<LevelChanger>().level11();
        }
        else if (PlayerPrefs.GetInt("difficulty") == 12)
        {
            levelChanger.GetComponent<LevelChanger>().level12();
        }
        else if (PlayerPrefs.GetInt("difficulty") == 13)
        {
            levelChanger.GetComponent<LevelChanger>().level13();
        }
        else if (PlayerPrefs.GetInt("difficulty") == 14)
        {
            levelChanger.GetComponent<LevelChanger>().level14();
        }
        else if (PlayerPrefs.GetInt("difficulty") == 15)
        {
            levelChanger.GetComponent<LevelChanger>().level15();
        }
        else if (PlayerPrefs.GetInt("difficulty") == 16)
        {
            levelChanger.GetComponent<LevelChanger>().level16();
        }
        else
        {
            levelChanger.GetComponent<LevelChanger>().level10();
            PlayerPrefs.SetInt("difficulty", 10);
        }
    }
}
