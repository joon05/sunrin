using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
   
    public void ShutDown()//눌렸을때
    {
        //버튼 눌렸을때 종료
        Application.Quit();
    }
}
