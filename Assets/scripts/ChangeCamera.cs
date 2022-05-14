using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public float sec;
    public GameObject fromCamera;
    public GameObject toCamera;
    void Start()
    {
        StartCoroutine(ExecuteAfterTime(sec));

    }
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        toCamera.SetActive(true);
        fromCamera.SetActive(false);
    }
}
