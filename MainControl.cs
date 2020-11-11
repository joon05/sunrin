using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainControl : MonoBehaviour//중앙제어 코드
{
    //싱글톤 
    public static MainControl Instance;
    public string turn;//현재 턴
    public bool anyc = false;//어떤 유닛이 클릭되어 있는가?
    public string act;//현재 하는 행동
    public string su;//선택된 유닛
    public int leftr;//남은 레드 유닛
    public int leftb;//남은 블루 유닛
    public  bool destroy = false;//타일 삭제 연산
    //여기부터 각 유닛 gameobject에 저장
   
    //여기까지 각 유닛 gameobject에 저장
    private void Awake() 
    {
      
        leftb = 5;
        leftr = 5;
        Instance = this;
       
    }
    private void Start()
    {
        turn =  "red";//시작시 턴은 레드팀
    }

    
    private void Update()
    {
        
    }
}
