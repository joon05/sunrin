using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackbutton : MonoBehaviour
{
    private GameObject su;
    public GameObject st;//선택 타일 
    public GameObject bb;
   
  
    void Update()
    {
        su = GameObject.Find(MainControl.Instance.su);//su에 선택된 게임 오브젝트 가져옴
       

    }
    private void OnMouseDown()
    {
        Instantiate(bb, new Vector3((float)(su.transform.position.x), (float)(su.transform.position.y + 0.3), -3), Quaternion.identity);
        MainControl.Instance.act = "attack";
        if (MainControl.Instance.su=="RTM")//마법사일경우 2칸 떨어진 곳에 선택 타일 생성
        {
            Instantiate(st, new Vector2((float)(su.transform.position.x+3), (float)(su.transform.position.y)),Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y-1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x ), (float)(su.transform.position.y-3)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x -1.5), (float)(su.transform.position.y-1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x -3), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 1.5), (float)(su.transform.position.y+1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y+1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x ), (float)(su.transform.position.y+3)), Quaternion.identity);
        }
        else if (MainControl.Instance.su == "BTM") //마법사일경우 2칸 떨어진 곳에 선택 타일 생성
        {
            Instantiate(st, new Vector2((float)(su.transform.position.x + 3), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y - 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x), (float)(su.transform.position.y - 3)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 1.5), (float)(su.transform.position.y - 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 3), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 1.5), (float)(su.transform.position.y + 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y + 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x), (float)(su.transform.position.y + 3)), Quaternion.identity);
        }
        else //근접 유닛은 한칸 거리에 선택 타일 생성
        {
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x  ), (float)(su.transform.position.y-1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + -1.5), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x ), (float)(su.transform.position.y+1.5)), Quaternion.identity);
        }
        Destroy(GameObject.Find("ａｔｔａｃｋ　ｂｕｔｔｏｎ(Clone)"));
        Destroy(GameObject.Find("ｍｏｖｅ　ｂｕｔｔｏｎ(Clone)"));
        Destroy(GameObject.Find("ｂａｃｋ　ｂｕｔｔｏｎ(Clone)"));
    }
}
