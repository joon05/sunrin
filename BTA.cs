using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BTA : MonoBehaviour //블루팀 어쎄신 코드
{
    //능력치 세팅

    public static int rta_life = 3;
    public static int rta_atc = 1;
    public GameObject bb;//백버튼
    public GameObject ab;//어택 버튼
    public GameObject mb;//무브 버튼
    void Start()
    {
        this.transform.position = new Vector3(3, 0, -1);//매 시작 위치
    }


    void Update()
    {


    }
    private void OnMouseDown()//클릭되었을때
    {
        MainControl.Instance.destroy = false;
        if (MainControl.Instance.anyc == false)//아무도 클릭되어 있지 않다면
        {
            if (MainControl.Instance.turn == "blue") //만약 턴이 블루팀이라면
            {
                MainControl.Instance.anyc = true;//어떤 유닛이든지 선택됬는가? TRUE 
                MainControl.Instance.su = "BTA";//선택된 유닛 BTA
                Instantiate(bb, new Vector3((float)(this.transform.position.x), (float)(this.transform.position.y + 0.3), -3), Quaternion.identity);
                Instantiate(ab, new Vector3((float)(this.transform.position.x), (float)(this.transform.position.y + 1.2), -3), Quaternion.identity);
                Instantiate(mb, new Vector3((float)(this.transform.position.x), (float)(this.transform.position.y + 1.8), -3), Quaternion.identity);
            }
        }
    }
}
