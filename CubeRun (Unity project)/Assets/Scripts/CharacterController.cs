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
        tipState = PlayerPrefs.GetInt("tip");
        if (tipState == 0)
        {
            tip.SetActive(true);
            tip2.SetActive(false);
        }
        else
        {
            tip.SetActive(false);
            tip2.SetActive(true);
        }
        if (tip.activeInHierarchy == false) PlayerPrefs.SetInt("tip", 1);
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
            coins = coins + arcadeMoney;
            PlayerPrefs.SetInt("arcadeMoney", arcadeMoney);
            PlayerPrefs.SetInt("coins", coins);
            coinNumber = coinText.GetComponent<Text>();
            coinNumber.text = "" + coins;
            PlayerPrefs.SetInt("state", 0);
            PlayerPrefs.SetInt("state", 1);
        }

        tipState = PlayerPrefs.GetInt("tip");
        if (tipState == 0)
        {
            tip.SetActive(true);
        }
        else
            tip.SetActive(false);
        if (tip.activeInHierarchy == false) PlayerPrefs.SetInt("tip", 1);
        //maxPostemp = PlayerPrefs.GetFloat("maxPostemp");
        coins = PlayerPrefs.GetInt("coins");
        coinNumber = coinText.GetComponent<Text>();
        coinNumber.text = "" + coins;

        if (transform.position.z >= 41 && transform.position.y == -20)
        {
            points = PlayerPrefs.GetFloat("points");
            points = points + 1;
            PlayerPrefs.SetFloat("points", points);
            state = 1;
            PlayerPrefs.SetInt("state", state);
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
}
