using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ALR_MenuEnterName : MonoBehaviour
{
    //private GameObject gameManager;

    public string newName = "Enter your name";
    private string[] arrNameWinner = new string[5];
    private int rank;


    // Start is called before the first frame update
    void Start()
    {
        rank = PlayerPrefs.GetInt("Rank");
        arrNameWinner[0] = PlayerPrefs.GetString("Name_One");
        arrNameWinner[1] = PlayerPrefs.GetString("Name_Two");
        arrNameWinner[2] = PlayerPrefs.GetString("Name_Three");
        arrNameWinner[3] = PlayerPrefs.GetString("Name_Four");
        arrNameWinner[4] = PlayerPrefs.GetString("Name_Five");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("h"))
        {
            UpdateName(rank);


        }

    }

    void OnGUI()
    {
        // Make a text field that modifies stringToEdit.
        newName = GUI.TextField(new Rect((Screen.width/2) - 50, (Screen.height/2) - 25, 100, 30), newName, 5);
    }

    public void UpdateName(int rang)
    {
        Debug.Log("RANK : " + rang);
        switch (rang)
        {
            
            case 0:
                PlayerPrefs.SetString("Name_One", newName);
                PlayerPrefs.SetString("Name_Two", arrNameWinner[0]);
                PlayerPrefs.SetString("Name_Three", arrNameWinner[1]);
                PlayerPrefs.SetString("Name_Four", arrNameWinner[2]);
                PlayerPrefs.SetString("Name_Five", arrNameWinner[3]);

                arrNameWinner[0] = PlayerPrefs.GetString("Name_One");
                arrNameWinner[1] = PlayerPrefs.GetString("Name_Two");
                arrNameWinner[2] = PlayerPrefs.GetString("Name_Three");
                arrNameWinner[3] = PlayerPrefs.GetString("Name_Four");
                arrNameWinner[4] = PlayerPrefs.GetString("Name_Five");
                break;


            case 1:


                PlayerPrefs.SetString("Name_Two", newName);
                PlayerPrefs.SetString("Name_Three", arrNameWinner[1]);
                PlayerPrefs.SetString("Name_Four", arrNameWinner[2]);
                PlayerPrefs.SetString("Name_Five", arrNameWinner[3]);

                arrNameWinner[0] = PlayerPrefs.GetString("Name_One");
                arrNameWinner[1] = PlayerPrefs.GetString("Name_Two");
                arrNameWinner[2] = PlayerPrefs.GetString("Name_Three");
                arrNameWinner[3] = PlayerPrefs.GetString("Name_Four");
                arrNameWinner[4] = PlayerPrefs.GetString("Name_Five");
                break;


            case 2:


                PlayerPrefs.SetString("Name_Three", newName);
                PlayerPrefs.SetString("Name_Four", arrNameWinner[2]);
                PlayerPrefs.SetString("Name_Five", arrNameWinner[3]);


                arrNameWinner[0] = PlayerPrefs.GetString("Name_One");
                arrNameWinner[1] = PlayerPrefs.GetString("Name_Two");
                arrNameWinner[2] = PlayerPrefs.GetString("Name_Three");
                arrNameWinner[3] = PlayerPrefs.GetString("Name_Four");
                arrNameWinner[4] = PlayerPrefs.GetString("Name_Five");
                break;


            case 3:
                PlayerPrefs.SetString("Name_Four", newName);
                PlayerPrefs.SetString("Name_Five", arrNameWinner[3]);

                arrNameWinner[0] = PlayerPrefs.GetString("Name_One");
                arrNameWinner[1] = PlayerPrefs.GetString("Name_Two");
                arrNameWinner[2] = PlayerPrefs.GetString("Name_Three");
                arrNameWinner[3] = PlayerPrefs.GetString("Name_Four");
                arrNameWinner[4] = PlayerPrefs.GetString("Name_Five");
                break;

            case 4:
                PlayerPrefs.SetString("Name_Five", newName);

                arrNameWinner[0] = PlayerPrefs.GetString("Name_One");
                arrNameWinner[1] = PlayerPrefs.GetString("Name_Two");
                arrNameWinner[2] = PlayerPrefs.GetString("Name_Three");
                arrNameWinner[3] = PlayerPrefs.GetString("Name_Four");
                arrNameWinner[4] = PlayerPrefs.GetString("Name_Five");
                break;

            default:
                break;

        }
            SceneManager.LoadScene("Menu_HighScore");
        }
}
