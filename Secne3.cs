using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secne3 : MonoBehaviour
{
    public GameObject r;
    public GameObject b;
    // Start is called before the first frame update
    void Start()
    {
        r.SetActive(false);
        b.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (MainControl.Instance.leftb == 0) 
        {
            r.SetActive(true);
        }
        else if (MainControl.Instance.leftr == 0) 
        {
            b.SetActive(true);
        }
    }
}
