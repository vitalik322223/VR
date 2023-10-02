using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activation : MonoBehaviour
{
    public GameObject cube;
    public int a = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
