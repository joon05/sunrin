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
    public GameObject rta;//레드팀 암살자
    public GameObject rtw;//레드팀 광전사
    public GameObject rts;//레드팀 기사
    public GameObject rtm;//레드팀 마법사
    public GameObject rtl;//레드팀 기마병
    public GameObject bta;//블루팀 암살자
    public GameObject btw;//블루팀 광전사
    public GameObject bts;//블루팀 기사
    public GameObject btm;//블루팀 마법사
    public GameObject btl;//블루팀 기마병
    //여기까지 각 유닛 gameobject에 저장
    private void Awake() 
    {
        Instance = this;
        //여기부터 각 유닛의 정보 가져오는 코드
        RTA rta_x = GameObject.Find("RTA").GetComponent<RTA>();
        RTA rta_y = GameObject.Find("RTA").GetComponent<RTA>();
        RTA rta_life = GameObject.Find("RTA").GetComponent<RTA>();
        RTA rta_atc = GameObject.Find("RTA").GetComponent<RTA>();
        //여기까지 각 유닛의 정보를 가져오는 코드
    }
    private void Start()
    {
        turn =  "red";//시작시 턴은 레드팀
    }

    
    private void Update()
    {
        
    }
}
