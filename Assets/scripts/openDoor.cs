using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openDoor : MonoBehaviour
{
    public GameObject[] open;
    public GameObject[] close;
     void Awake()
    {
        GameObject op = new GameObject();
        op.AddComponent<HappyScore>();
        HappyScore SN = op.GetComponent<HappyScore>();
        string name = SN.GETsceneName();
            if (name == "happyQuiz")
            {
                open[0].transform.position = new Vector3(41.5977f, 341.9409f, 163.7766f);
            }
            else if (name == "sadQuiz")
            {
                open[1].transform.position = new Vector3(62.3f, 341f, 164.8f);
            }
            else if (name == "fearQuiz")
            {
                open[2].transform.position = new Vector3(41.5977f, 341.9409f, 163.7766f);
            }
            else if (name == "discostQuiz")
            {
                open[3].transform.position = new Vector3(62.36f, 340.84f, 164.76f);
            }
            else if (name == "surprisedQuiz")
            {
                open[4].transform.position = new Vector3(41.5977f, 341.9409f, 163.7766f);
            }
    }
}
