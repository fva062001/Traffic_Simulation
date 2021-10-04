using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tlManager1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Red;
    public GameObject Yellow;
    public GameObject Green;
    public int carStop;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(trafficLights1());
    }

    void tlYellow1()
    {
        Red.SetActive(true);
        Yellow.SetActive(false);
        Green.SetActive(true);
        carStop = 0;
    }

    void tlRed1()
    {
        Red.SetActive(false);
        Yellow.SetActive(true);
        Green.SetActive(true);
        carStop = 1;
    }

    void tlGreen1()
    {
        Red.SetActive(true);
        Yellow.SetActive(true);
        Green.SetActive(false);
        carStop = 0;
    }

    IEnumerator trafficLights1()
    {
        while (true)
        {
            tlRed1();
            yield return new WaitForSeconds(11);
            tlGreen1();
            yield return new WaitForSeconds(7);
            tlYellow1();
            yield return new WaitForSeconds(4);
        }
    }
}
