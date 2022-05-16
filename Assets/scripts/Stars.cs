using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stars : MonoBehaviour
{
    public GameObject[] stars;
    public GameObject[] total;
    public Text sText;
    HappyScore star;
    private void Start()
    {
        
    }

    private void Update()
    {

        if (SceneManager.GetActiveScene().name =="totalScore")
        {
            int t;
            GameObject obj = new GameObject();
            obj.AddComponent<HappyScore>();
            star = obj.GetComponent<HappyScore>();
            t = star.getHappyScore();
            if (t == 1)
                total[0].SetActive(true);
            else if (t == 2)
            {
                total[0].SetActive(true);
                total[1].SetActive(true);
            }
            else if (t == 3)
            {
                total[0].SetActive(true);
                total[1].SetActive(true);
                total[2].SetActive(true);
            }
            t = star.getSadScore();
            if (t == 1)
                total[3].SetActive(true);
            else if (t == 2)
            {
                total[3].SetActive(true);
                total[4].SetActive(true);
            }
            else if (t == 3)
            {
                total[3].SetActive(true);
                total[4].SetActive(true);
                total[5].SetActive(true);
            }
            t = star.getFearScore();
            if (t == 1)
                total[6].SetActive(true);
            else if (t == 2)
            {
                total[6].SetActive(true);
                total[7].SetActive(true);
            }
            else if (t == 3)
            {
                total[6].SetActive(true);
                total[7].SetActive(true);
                total[8].SetActive(true);
            }
            t = star.getDiscostScore();
            if (t == 1)
                total[9].SetActive(true);
            else if (t == 2)
            {
                total[9].SetActive(true);
                total[10].SetActive(true);
            }
            else if (t == 3)
            {
                total[9].SetActive(true);
                total[10].SetActive(true);
                total[11].SetActive(true);
            }
            t = star.getSurprizeScore();
            if (t == 1)
                total[12].SetActive(true);
            else if (t == 2)
            {
                total[12].SetActive(true);
                total[13].SetActive(true);
            }
            else if (t == 3)
            {
                total[12].SetActive(true);
                total[13].SetActive(true);
                total[14].SetActive(true);
            }
            t = star.getAngryScore();
            if (t == 1)
                total[15].SetActive(true);
            else if (t == 2)
            {
                total[15].SetActive(true);
                total[16].SetActive(true);
            }
            else if (t == 3)
            {
                total[15].SetActive(true);
                total[16].SetActive(true);
                total[17].SetActive(true);
            }
        }
    }
    public void starsAchieved(string StarAppear)
    {
        int ST;
        GameObject obj = new GameObject();
        obj.AddComponent<HappyScore>();
        star = obj.GetComponent<HappyScore>();
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
        else if (StarAppear == "surprizeQuiz")
        {
            ST = star.getSurprizeScore();
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
