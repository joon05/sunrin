using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour
{
    // help버튼으로 변화시킬 ui들
    public GameObject h;
    public GameObject b;
    public GameObject i1;
    public GameObject i2;
    public GameObject i3;
    public GameObject i4;

   
    public void H()//눌렸을때
    {
        //ui true로 바꾸고 중요한 ui  false
        h.SetActive(true);
        b.SetActive(true);
        i1.SetActive(false);
        i2.SetActive(false);
        i3.SetActive(false);
        i4.SetActive(false);
    }
}
