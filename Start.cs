using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Start : MonoBehaviour
{
    public void Next() //눌렸을때
    {
        //버튼이 눌렸을때 다음 씬으로 넘어가는 코드
        SceneManager.LoadScene("SampleScene");
    }
}
