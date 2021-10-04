using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tlManager : MonoBehaviour
{
    public GameObject Red;
    public GameObject Yellow;
    public GameObject Green;
    public int carStop;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(trafficLights());
    }

    void tlYellow()
    {
        Red.SetActive(true);
        Yellow.SetActive(false);
        Green.SetActive(true);
        carStop = 0;
    }

    void tlRed()
    {
        Red.SetActive(false);
        Yellow.SetActive(true);
        Green.SetActive(true);
        carStop = 1;
    }

    void tlGreen()
    {
        Red.SetActive(true);
        Yellow.SetActive(true);
        Green.SetActive(false);
        carStop = 0;
    }

    IEnumerator trafficLights()
    {
        while(true)
        {
            tlGreen();
            yield return new WaitForSeconds(7);
            tlYellow();
            yield return new WaitForSeconds(4);
            tlRed();
            yield return new WaitForSeconds(11);
        }
    }




}
