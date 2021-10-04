using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMovement : MonoBehaviour
{
    public GameObject Btn;
    public UnityEngine.UIElements.Slider Slider;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Slow()
    {
        Time.timeScale = speed;
    }

    public void Medium()
    {
        Time.timeScale = speed;
    }

    public void High()
    {
        Time.timeScale = speed;
    }
    public void Reset_()
    {
        Time.timeScale = 1f;
    }

    public void slider()
    {
        Time.timeScale = Slider.value;
    }





}
