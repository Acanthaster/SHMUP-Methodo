using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ALR_MenuHighScore : MonoBehaviour
{

    private GameObject nbOne;
    private Text txtOne;
    private GameObject oneName;
    private Text oneTxt;

    private GameObject nbTwo;
    private Text txtTwo;
    private GameObject twoName;
    private Text twoTxt;

    private GameObject nbThree;
    private Text txtThree;
    private GameObject threeName;
    private Text threeTxt;


    private GameObject nbFour;
    private Text txtFour;
    private GameObject fourName;
    private Text fourTxt;


    private GameObject nbFive;
    private Text txtFive;
    private GameObject fiveName;
    private Text fiveTxt;


    // Start is called before the first frame update
    void Start()
    {
        nbOne = GameObject.Find("HighSc1");
        txtOne = nbOne.GetComponent<Text>();
        txtOne.text = PlayerPrefs.GetInt("HS_One").ToString();

        oneName = GameObject.Find("Name_1");
        oneTxt = oneName.GetComponent<Text>();
        oneTxt.text = PlayerPrefs.GetString("Name_One");

        nbTwo = GameObject.Find("HighSc2");
        txtTwo = nbTwo.GetComponent<Text>();
        txtTwo.text = PlayerPrefs.GetInt("HS_Two").ToString();

        twoName = GameObject.Find("Name_2");
        twoTxt = twoName.GetComponent<Text>();
        twoTxt.text = PlayerPrefs.GetString("Name_Two");

        nbThree = GameObject.Find("HighSc3");
        txtThree = nbThree.GetComponent<Text>();
        txtThree.text = PlayerPrefs.GetInt("HS_Three").ToString();

        threeName = GameObject.Find("Name_3");
        threeTxt = threeName.GetComponent<Text>();
        threeTxt.text = PlayerPrefs.GetString("Name_Three");

        nbFour = GameObject.Find("HighSc4");
        txtFour = nbFour.GetComponent<Text>();
        txtFour.text = PlayerPrefs.GetInt("HS_Four").ToString();

        fourName = GameObject.Find("Name_4");
        fourTxt = fourName.GetComponent<Text>();
        fourTxt.text = PlayerPrefs.GetString("Name_Four");

        nbFive = GameObject.Find("HighSc5");
        txtFive = nbFive.GetComponent<Text>();
        txtFive.text = PlayerPrefs.GetInt("HS_Five").ToString();

        fiveName = GameObject.Find("Name_5");
        fiveTxt = fiveName.GetComponent<Text>();
        fiveTxt.text = PlayerPrefs.GetString("Name_Five");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
