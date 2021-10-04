using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car1Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector3 position = new Vector3(-106.76f, 48.2f, 0f);
    public GameObject myPrefab;
    public GameObject tl;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myPrefab = GameObject.FindWithTag("Car1");
        tl = GameObject.FindWithTag("tfLight1");
    }

    // Update is called once per frame
    void Update()
    {
        if (tl.GetComponent<tlManager1>().carStop.Equals(0))
        {
            carMovement();
        }
    }
    public void carMovement()
    {
        rb.velocity = new Vector2(0f, -75f);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(this.gameObject, position, Quaternion.Euler(0f, 0f, -179.97f));
        Destroy(this.gameObject);
        this.gameObject.name = "Car";
    }

}
