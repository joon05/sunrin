﻿using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class SelectTile : MonoBehaviour//선택 타일 코드
{
    public AudioSource audioSource;
    private GameObject su;//선택된 게임오브젝트 선언
    public GameObject ia;//공격 판정을 만들어줄 투명한 오브젝트
    float x;
    float y;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();//사운드
    }
    void Update()
    {
        su = GameObject.Find(MainControl.Instance.su); //Gameobject su에 선택된 게임오브젝트를 넣는다
        this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y,-2);
        x = this.gameObject.transform.position.x;
        y= this.gameObject.transform.position.y;
 
        if (MainControl.Instance.destroy == true) 
        {
            Destroy(this.gameObject);
          
        }
        if (this.gameObject.transform.position.x>3||this.gameObject.transform.position.x<-3||this.gameObject.transform.position.y>3||this.gameObject.transform.position.y<-3)//이 프리팹이 맵 밖에 있을시 삭제하는 코드
        {
            Destroy(this.gameObject);
        }
    }
    private void OnMouseDown()//클릭되었을때
    {
        audioSource.Play();
        Destroy(GameObject.Find("ｂａｃｋ　ｂｕｔｔｏｎ(Clone)"));
        if (MainControl.Instance.act == "move")//현재 행동이 move일경우
        {
            su.transform.position = new Vector3(x,y,su.transform.position.z);//선택된 게임 오브젝트를 이 오브젝트 위치로 옮김
            MainControl.Instance.anyc = false;
            if (MainControl.Instance.turn=="red") //턴전환
            {
                MainControl.Instance.turn = "blue";
            }
            else 
            {
                MainControl.Instance.turn = "red";
            }
            MainControl.Instance.destroy = true;
        }
        if (MainControl.Instance.act == "attack")//현재 행동이 attack일경우
        {
            Instantiate(ia,new Vector2(this.transform.position.x,this.transform.position.y), Quaternion.identity);
            MainControl.Instance.anyc = false;
            if (MainControl.Instance.turn == "red")//턴전환
            {
                MainControl.Instance.turn = "blue";
            }
            else
            {
                MainControl.Instance.turn = "red";
            }
            MainControl.Instance.destroy = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)//다른것에 닿았을때
    {
        if (MainControl.Instance.act== "move")//현재 행동이 move라면
        {
            if (other.gameObject.tag == "unit") //닿은게 유닛이라면
            {
                Destroy(this.gameObject);
            }
          
            
        }//요약:유닛에 닿으면 삭제
        if (MainControl.Instance.act == "attack")//현재 행동이 attack라면
        {
            if (other.gameObject.tag == "unit") //닿은게 유닛이라면
            {
                Debug.Log("unit");
            }
            else 
            {
                //Destroy(this.gameObject);
            }


        }
    }

}
