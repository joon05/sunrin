using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.VR;
using UnityEngine;

public class SelectTile : MonoBehaviour//선택 타일 코드
{
    private GameObject su;//게임오브젝트 선언
    

    
    void Update()
    {
        su = GameObject.Find(MainControl.Instance.su);//Gameobject su에 선택된 게임오브젝트를 넣는다
        if (MainControl.Instance.destroy == true) 
        {
            Destroy(this);
        }
    }
    private void OnMouseDown()//클릭되었을때
    {
        if (MainControl.Instance.act == "move")//현재 행동이 move일경우
        {
            su.transform.position = new Vector2(this.transform.position.x, this.transform.position.y);//선택된 게임 오브젝트를 이 오브젝트 위치로 옮김
            MainControl.Instance.anyc = false;
            if (MainControl.Instance.turn=="red") 
            {
                MainControl.Instance.turn = "blue";
            }
            else 
            {
                MainControl.Instance.turn = "red";
            }
        }
        if (MainControl.Instance.act == "attack")//현재 행동이 attack일경우
        {
        
        }
    }
}
