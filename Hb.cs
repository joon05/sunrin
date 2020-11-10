using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hb : MonoBehaviour
{
    //변화시킬 ui들
    public GameObject h;
    public GameObject b;
    public GameObject i1;
    public GameObject i2;
    public GameObject i3;
    public GameObject i4;
    public void Click() //눌렸을때
    {
        //ui false로 바꾸고 중요한 ui 다시 true
       
        b.SetActive(false);
        i1.SetActive(true);
        i2.SetActive(true);
        i3.SetActive(true);
        i4.SetActive(true);
        h.SetActive(false);
    }
}
