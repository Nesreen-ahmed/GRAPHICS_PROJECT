using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stars : MonoBehaviour
{
    public GameObject[] stars;
    public Text sText;
    
    public void starsAchieved(string StarAppear)
    {
        int ST;
        GameObject obj = new GameObject();
        obj.AddComponent<HappyScore>();
        HappyScore star = obj.GetComponent<HappyScore>();
        if (StarAppear == "happyQuiz")
        {
            ST = star.getHappyScore();
            if (ST == 1)
                stars[0].SetActive(true);
            else if (ST == 2)
            {
                stars[0].SetActive(true);
                stars[1].SetActive(true);
            }
            else if (ST == 3)
            {
                stars[0].SetActive(true);
                stars[1].SetActive(true);
                stars[2].SetActive(true);
            }
        }
        else if (StarAppear == "sadQuiz")
        {
            ST = star.getSadScore();
            if (ST == 1)
                stars[0].SetActive(true);
            else if (ST == 2)
            {
                stars[0].SetActive(true);
                stars[1].SetActive(true);
            }
            else if (ST == 3)
            {
                stars[0].SetActive(true);
                stars[1].SetActive(true);
                stars[2].SetActive(true);
            }
        }
        else if (StarAppear == "angryQuiz")
        {
            ST = star.getAngryScore();
            if (ST == 1)
                stars[0].SetActive(true);
            else if (ST == 2)
            {
                stars[0].SetActive(true);
                stars[1].SetActive(true);
            }
            else if (ST == 3)
            {
                stars[0].SetActive(true);
                stars[1].SetActive(true);
                stars[2].SetActive(true);
            }
        }
        else if (StarAppear == "fearQuiz")
        {
            ST = star.getFearScore();
            if (ST == 1)
                stars[0].SetActive(true);
            else if (ST == 2)
            {
                stars[0].SetActive(true);
                stars[1].SetActive(true);
            }
            else if (ST == 3)
            {
                stars[0].SetActive(true);
                stars[1].SetActive(true);
                stars[2].SetActive(true);
            }
        }
        else if (StarAppear == "discostQuiz")
        {
            ST = star.getDiscostScore();
            if (ST == 1)
                stars[0].SetActive(true);
            else if (ST == 2)
            {
                stars[0].SetActive(true);
                stars[1].SetActive(true);
            }
            else if (ST == 3)
            {
                stars[0].SetActive(true);
                stars[1].SetActive(true);
                stars[2].SetActive(true);
            }
        }
        else if (StarAppear == "surprisedQuiz")
        {
            ST = star.getSurprisedScore();
            if (ST == 1)
                stars[0].SetActive(true);
            else if (ST == 2)
            {
                stars[0].SetActive(true);
                stars[1].SetActive(true);
            }
            else if (ST == 3)
            {
                stars[0].SetActive(true);
                stars[1].SetActive(true);
                stars[2].SetActive(true);
            }
        }

    }
  
}
