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
    private static int surprisedScore = 0;
    string temp;
    static string sn="";
    void Start()
    {
        temp = SceneManager.GetActiveScene().name;
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
            surprisedScore++;
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
    public int getSurprisedScore()
    {
        return surprisedScore;
    }
    public void replay(string emotion)
    {
        if (emotion == "happyQuiz")
            happyScore=0;
        else if (emotion == "sadQuiz")
            sadScore=0;
        else if (emotion == "angryQuiz")
            angryScore=0;
        else if (emotion == "fearQuiz")
            fearScore=0;
        else if (emotion == "discostQuiz")
            discostScore=0;
        else if (emotion== "surprisedQuiz")
            surprisedScore=0;
    }
}
