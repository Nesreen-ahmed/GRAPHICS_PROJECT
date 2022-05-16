using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openDoor : MonoBehaviour
{
    public GameObject[] open;
    public GameObject[] close;
    public GameObject maged;
     void Awake()
    {
        GameObject op = new GameObject();
        op.AddComponent<HappyScore>();
        HappyScore SN = op.GetComponent<HappyScore>();
        string name = SN.GETsceneName();
        Debug.Log(name);
        if (name == "happyQuiz")
        {
                open[0].transform.eulerAngles = new Vector3(0f, -90f, 0f);
                close[0].transform.eulerAngles = new Vector3(0f, -188.338f, 0f);
                 maged.transform.position = new Vector3(234.5f, 1.929326f, 523.4f);
            maged.transform.eulerAngles = new Vector3(0f, 124.277f, 0f);
        }
            else if (name == "sadQuiz")
            {
                open[1].transform.eulerAngles = new Vector3(0f, 11.078f, 0f);
                close[1].transform.eulerAngles = new Vector3(0f, 0f, 0f);
                maged.transform.position = new Vector3(275.1f, 1.5f, 435.9f);
                maged.transform.eulerAngles = new Vector3(0f, 215.891f, 0f);
        }
        else if (name == "fearQuiz")
            {
                open[2].transform.eulerAngles = new Vector3(0f, -90f, 0f);
                close[2].transform.eulerAngles = new Vector3(0f, 170f, 0f);
            maged.transform.position = new Vector3(232.6f, 1.5f, 370.4f);
            maged.transform.eulerAngles = new Vector3(0f, 139.76f, 0f);
        }
        else if (name == "discostQuiz")
            {
                open[3].transform.eulerAngles = new Vector3(0f, 11.078f, 0f);
                close[3].transform.eulerAngles = new Vector3(0f, 0f, 0f);
                maged.transform.position = new Vector3(327.8f, 1.5f, 207.3f);
                maged.transform.eulerAngles = new Vector3(0f, 232.517f, 0f);
        }
        else if (name == "surprizeQuiz")
            {
                open[4].transform.eulerAngles = new Vector3(0f, -40f, 0f);
                close[4].transform.eulerAngles = new Vector3(0f, 160f, 0f);
                maged.transform.position = new Vector3(300f, 1.5f, 122.2f);
                maged.transform.eulerAngles = new Vector3(0f, 124.277f, 0f);
        }
    }
}
