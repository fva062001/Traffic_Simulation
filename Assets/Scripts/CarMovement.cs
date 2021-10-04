using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    private Vector3 position = new Vector3(68.9f, -47.4f, 0f);
    public GameObject myPrefab;
    public GameObject tl;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myPrefab = GameObject.FindWithTag("Car");
        tl = GameObject.FindWithTag("tfLight");
    }

    // Update is called once per frame
    void Update()
    {
        if (tl.GetComponent<tlManager>().carStop.Equals(0))
        {
            carMovement();
        }
        
    }


    public void carMovement()
    {
        rb.velocity = new Vector2(-75f, 0f);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(this.gameObject, position, Quaternion.Euler(0f,0f,-90.16f));
        Destroy(this.gameObject);
        this.gameObject.name = "Car";
    }
}
