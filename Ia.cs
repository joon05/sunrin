using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ia : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }
    private void Update()
    {
        if (MainControl.Instance.destroy==false)
        {
            Destroy(this.gameObject);
        }
    }
}
