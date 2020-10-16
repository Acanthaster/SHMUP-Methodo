using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ALR_ScoreManager : MonoBehaviour
{

    //VARIABLES FOR SCORES
    public int totalScore = 0;
    public int nmiVertiValue;
    public int nmiStaticValue;
    public int nmiCircleValue;



    //VARIABLES FOR HIGH SCORES
    private static int highScore;
    private static int finalScore;
    private static string newName;

    private static int HS_One;
    private static int HS_Two;
    private static int HS_Three;
    private static int HS_Four;
    private static int HS_Five;

    private int[] arrHighScore = new int[5];
    private string[] arrNameWinner = new string[5];


    private void Awake()
    {
        finalScore = 0;

        if (!PlayerPrefs.HasKey("HS_One"))
        {
            PlayerPrefs.SetInt("HS_One", 0);
            PlayerPrefs.SetInt("HS_Two", 0);
            PlayerPrefs.SetInt("HS_Three", 0);
            PlayerPrefs.SetInt("HS_Four", 0);
            PlayerPrefs.SetInt("HS_Five", 0);

            PlayerPrefs.SetString("Name_One", "AAAAA");
            PlayerPrefs.SetString("Name_Two", "BBBBB");
            PlayerPrefs.SetString("Name_Three", "CCCCC");
            PlayerPrefs.SetString("Name_Four", "DDDDD");
            PlayerPrefs.SetString("Name_Five", "EEEEE");

            PlayerPrefs.SetInt("Rank", 0);


            arrHighScore[0] = PlayerPrefs.GetInt("HS_One");
            arrHighScore[1] = PlayerPrefs.GetInt("HS_Two");
            arrHighScore[2] = PlayerPrefs.GetInt("HS_Three");
            arrHighScore[3] = PlayerPrefs.GetInt("HS_Four");
            arrHighScore[4] = PlayerPrefs.GetInt("HS_Five");

            arrNameWinner[0] = PlayerPrefs.GetString("Name_One");
            arrNameWinner[1] = PlayerPrefs.GetString("Name_Two");
            arrNameWinner[2] = PlayerPrefs.GetString("Name_Three");
            arrNameWinner[3] = PlayerPrefs.GetString("Name_Four");
            arrNameWinner[4] = PlayerPrefs.GetString("Name_Five");
        }
        else
        {
            arrHighScore[0] = PlayerPrefs.GetInt("HS_One");
            arrHighScore[1] = PlayerPrefs.GetInt("HS_Two");
            arrHighScore[2] = PlayerPrefs.GetInt("HS_Three");
            arrHighScore[3] = PlayerPrefs.GetInt("HS_Four");
            arrHighScore[4] = PlayerPrefs.GetInt("HS_Five");

            arrNameWinner[0] = PlayerPrefs.GetString("Name_One");
            arrNameWinner[1] = PlayerPrefs.GetString("Name_Two");
            arrNameWinner[2] = PlayerPrefs.GetString("Name_Three");
            arrNameWinner[3] = PlayerPrefs.GetString("Name_Four");
            arrNameWinner[4] = PlayerPrefs.GetString("Name_Five");
        }

        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("n"))
        {

            UpdateHighScore(totalScore);
            SceneManager.LoadScene("Scene_EnterName");
        }

    }


    public void AddScore(int enemyValue)
    {
        Debug.Log("Gain !" + enemyValue);
        totalScore += enemyValue;
        Debug.Log("I DIE !" + totalScore);
    }

    public void GetScore()
    {
        finalScore = totalScore;
    }

    public static int GetHighScore()
    {
        return highScore;

    }


    public void UpdateHighScore(int score)
    {
        for (int i=0; i<5; i++)
        {
            if(score >= arrHighScore[i])
            {
              
                PlayerPrefs.SetInt("Rank", i);
                Debug.Log(i);
                switch (i)
                {
                    case 0:
                        PlayerPrefs.SetInt("HS_One", score);
                        PlayerPrefs.SetInt("HS_Two", arrHighScore[0]);
                        PlayerPrefs.SetInt("HS_Three", arrHighScore[1]);
                        PlayerPrefs.SetInt("HS_Four", arrHighScore[2]);
                        PlayerPrefs.SetInt("HS_Five", arrHighScore[3]);


                        arrHighScore[0] = PlayerPrefs.GetInt("HS_One");
                        arrHighScore[1] = PlayerPrefs.GetInt("HS_Two");
                        arrHighScore[2] = PlayerPrefs.GetInt("HS_Three");
                        arrHighScore[3] = PlayerPrefs.GetInt("HS_Four");
                        arrHighScore[4] = PlayerPrefs.GetInt("HS_Five");
                        break;


                    case 1:
                        PlayerPrefs.SetInt("HS_Two", score);
                        PlayerPrefs.SetInt("HS_Three", arrHighScore[1]);
                        PlayerPrefs.SetInt("HS_Four", arrHighScore[2]);
                        PlayerPrefs.SetInt("HS_Five", arrHighScore[3]);

                        arrHighScore[0] = PlayerPrefs.GetInt("HS_One");
                        arrHighScore[1] = PlayerPrefs.GetInt("HS_Two");
                        arrHighScore[2] = PlayerPrefs.GetInt("HS_Three");
                        arrHighScore[3] = PlayerPrefs.GetInt("HS_Four");
                        arrHighScore[4] = PlayerPrefs.GetInt("HS_Five");
                        break;


                    case 2:
                        PlayerPrefs.SetInt("HS_Three", score);
                        PlayerPrefs.SetInt("HS_Four", arrHighScore[2]);
                        PlayerPrefs.SetInt("HS_Five", arrHighScore[3]);

                        arrHighScore[0] = PlayerPrefs.GetInt("HS_One");
                        arrHighScore[1] = PlayerPrefs.GetInt("HS_Two");
                        arrHighScore[2] = PlayerPrefs.GetInt("HS_Three");
                        arrHighScore[3] = PlayerPrefs.GetInt("HS_Four");
                        arrHighScore[4] = PlayerPrefs.GetInt("HS_Five");
                        break;


                    case 3:
                        PlayerPrefs.SetInt("HS_Four", score);
                        PlayerPrefs.SetInt("HS_Five", arrHighScore[3]);

                        arrHighScore[0] = PlayerPrefs.GetInt("HS_One");
                        arrHighScore[1] = PlayerPrefs.GetInt("HS_Two");
                        arrHighScore[2] = PlayerPrefs.GetInt("HS_Three");
                        arrHighScore[3] = PlayerPrefs.GetInt("HS_Four");
                        arrHighScore[4] = PlayerPrefs.GetInt("HS_Five");
                        break;

                    case 4:
                        PlayerPrefs.SetInt("HS_Five", score);


                        arrHighScore[0] = PlayerPrefs.GetInt("HS_One");
                        arrHighScore[1] = PlayerPrefs.GetInt("HS_Two");
                        arrHighScore[2] = PlayerPrefs.GetInt("HS_Three");
                        arrHighScore[3] = PlayerPrefs.GetInt("HS_Four");
                        arrHighScore[4] = PlayerPrefs.GetInt("HS_Five");
                        break;

                    default:
                        break;

                }

                break;
            }
            else if (score < arrHighScore[i])
            {
                SceneManager.LoadScene("Scene_NoHighScore");
            }
        }
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {

            UpdateHighScore(totalScore);
            SceneManager.LoadScene("Scene_EnterName");

        }
    }



}
