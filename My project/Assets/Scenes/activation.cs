using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activation : MonoBehaviour
{
    public GameObject cube;
    public int a = 1;
    public float speed = 10f;
    public Text t;
    public int counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 5 * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 5 * speed * Time.deltaTime);
        }
        t.text = counter.ToString();
    }

    public void OnCollisionEnter(Collision collision)
    {
        counter--;
    }

    public void OnCollisionStay(Collision collision)
    {

    }

    public void OnCollisionExit(Collision collision)
    {

    }

    public void OnTriggerEnter(Collider other)
    {

    }

    public void OnTriggerStay(Collider other)
    {

    }

    public void OnTriggerExit(Collider other)
    {

    }

    public void activate()
    {
            if (a == 1)
        {
            this.gameObject.SetActive(false);
            a -= 1;
        }
            else
        {
            a += 1;
            this.gameObject.SetActive(true);
        }
    }
}
