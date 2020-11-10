using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RTA : MonoBehaviour //레드팀 어쎄신 코드
{
    //능력치 세팅
    public static float rta_x;
    public static float rta_y;
    public static int rta_life=3;
    public static int rta_atc = 1;
    public GameObject bb;//백버튼
    public GameObject ab;//어택 버튼
    public GameObject mb;//무브 버튼
    void Start()
    {
        rta_x = (float)(-4.5);
        rta_y = 0;//시작위치 세팅
    }

   
    void Update()
    {
        
        this.transform.position = new Vector2(rta_x, rta_y);//매 프레임마다 위치 이동
    }
    private void OnMouseDown()//클릭되었을때
    {
        if (MainControl.Instance.anyc == false)//아무도 클릭되어 있지 않다면
        {
            if (MainControl.Instance.turn == "red") //만약 턴이 레드팀이라면
            {
                MainControl.Instance.anyc = true;
                MainControl.Instance.su = "RTA";
                Instantiate(bb,new Vector2((float)(this.transform.position.x), (float)(this.transform.position.y+0.6)), Quaternion.identity);
                Instantiate(ab, new Vector2((float)(this.transform.position.x), (float)(this.transform.position.y + 1.2)), Quaternion.identity);
                Instantiate(mb, new Vector2((float)(this.transform.position.x), (float)(this.transform.position.y + 1.8)), Quaternion.identity);
            }
        }
    }
}
