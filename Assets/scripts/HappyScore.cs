using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HappyScore : MonoBehaviour
{
    private static int happyScore=0;
    private static int sadScore = 0;
    private static int angryScore = 0;
    private static int fearScore = 0;
    private static int discostScore = 0;
    private static int surprizeScore = 0;
    string temp;
    static string sn="";
    void Start()
    {
        temp = SceneManager.GetActiveScene().name;
    }

    private void Awake()
    {

        if (temp == "happyQuiz")
            happyScore = 0;
        else if (temp == "sadQuiz")
            sadScore = 0;
        else if (temp == "angryQuiz")
            angryScore = 0;
        else if (temp == "fearQuiz")
            fearScore = 0;
        else if (temp == "discostQuiz")
            discostScore = 0;
        else if (temp == "surprizeQuiz")
            surprizeScore = 0;
    }
    public void onclick()
    {
        if (temp == "happyQuiz")
            happyScore++;
        else if (temp == "sadQuiz")
            sadScore++;
        else if (temp == "angryQuiz")
            angryScore++;
        else if (temp == "fearQuiz")
            fearScore++;
        else if (temp == "discostQuiz")
            discostScore++;
        else if (temp == "surprizeQuiz")
            surprizeScore++;
        sn = temp;
    }

    public string GETsceneName()
    {
        return sn;
    }
    public int  getHappyScore()
    {
        return happyScore;
    }
    public int getSadScore()
    {
        return sadScore;
    }
    public int getFearScore()
    {
        return fearScore;
    }
    public int getAngryScore()
    {
        return angryScore;
    }
    public int getDiscostScore()
    {
        return discostScore;
    }
    public int getSurprizeScore()
    {
        return surprizeScore;
    }
}
