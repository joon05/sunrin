using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backbutton : MonoBehaviour//뒤로가기 버튼 코드
{
    private GameObject attackbutton;
    private GameObject movebutton;
    public GameObject bb;
    
  


    void Update()
    {
        attackbutton = GameObject.Find("attack button");//게임오브제에 프리팹 등록
        movebutton = GameObject.Find("move button");//게임오브제에 프리팹 등록
    }
    private void OnMouseDown()
    {
        Destroy(attackbutton);//attackbutton프리팹 파괴
        Destroy(movebutton);//movebutton프리팹 파괴
        MainControl.Instance.destroy = true;
        MainControl.Instance.anyc = false;
        Destroy(this);//이 프리팹 파괴
    }
}
