using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backbutton : MonoBehaviour//뒤로가기 버튼 코드
{
    public AudioSource audioSource;
    private GameObject attackbutton;
    private GameObject movebutton;
    public GameObject bb;



    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();//사운드
    }
    void Update()
    {
        attackbutton = GameObject.Find("ａｔｔａｃｋ　ｂｕｔｔｏｎ(Clone)");//게임오브제에 프리팹 등록
        movebutton = GameObject.Find("ｍｏｖｅ　ｂｕｔｔｏｎ(Clone)");//게임오브제에 프리팹 등록
    }
    private void OnMouseDown()
    {
        audioSource.Play();
        Destroy(attackbutton);//attackbutton프리팹 파괴
        Destroy(movebutton);//movebutton프리팹 파괴
        MainControl.Instance.destroy = true;
        MainControl.Instance.anyc = false;
        Destroy(GameObject.Find("ｂａｃｋ　ｂｕｔｔｏｎ(Clone)"));//이 프리팹 파괴
    }
}
