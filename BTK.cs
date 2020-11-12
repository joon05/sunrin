using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTK : MonoBehaviour
{
    public AudioSource audioSource;
    public static int btk_life = 5;
  
    public GameObject bb;//백버튼
    public GameObject ab;//어택 버튼
    public GameObject mb;//무브 버튼
    void Start()
    {
        audioSource = GetComponent<AudioSource>();//사운드
        this.transform.position = new Vector3(3, (float)-1.5, -1);//매 시작 위치


    }


    void Update()
    {
       
        if (btk_life <= 0)
        {
            MainControl.Instance.leftb = MainControl.Instance.leftb - 1;//죽을때 메인 컨트롤에 남은 블루팀 유닛수 줄임
            Destroy(this.gameObject);
           
        }
    }
    private void OnMouseDown()//클릭되었을때
    {
        MainControl.Instance.destroy = false;
        if (MainControl.Instance.anyc == false)//아무도 클릭되어 있지 않다면
        {
            if (MainControl.Instance.turn == "blue") //만약 턴이 블루팀이라면
            {
                audioSource.Play();
                MainControl.Instance.anyc = true;//어떤 유닛이든지 선택됬는가? TRUE 
                MainControl.Instance.su = "BTK";//선택된 유닛 BTK
                Instantiate(bb, new Vector3((float)(this.transform.position.x), (float)(this.transform.position.y + 0.3), -3), Quaternion.identity);
                Instantiate(ab, new Vector3((float)(this.transform.position.x), (float)(this.transform.position.y + 1.2), -3), Quaternion.identity);
                Instantiate(mb, new Vector3((float)(this.transform.position.x), (float)(this.transform.position.y + 1.8), -3), Quaternion.identity);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "attack") //피격 연산
        {
            if (MainControl.Instance.su == "RTA") //암살자에 공격받을시
            {

                int d = UnityEngine.Random.Range(1, 5);
                if (d == 4)
                {
                    MainControl.Instance.leftb = MainControl.Instance.leftb - 1;
                    Destroy(this.gameObject);
                }
                btk_life = btk_life - 1;
            }
            else if (MainControl.Instance.su == "RTW")//광전사한테 공격받을시
            {
                btk_life = btk_life - RTW.rtw_atc;
            }
            else if (MainControl.Instance.su == "RTK")//기사한테 공격받을시 
            {
                btk_life = btk_life - 3;
            }
            else if (MainControl.Instance.su == "RTM")//마법사에게 공격받을시
            {
                btk_life = btk_life - 3;
            }
            else if (MainControl.Instance.su == "RTL")//기마병에게 공격받을시 
            {
                btk_life = btk_life - 2;
            }
        }
    }
}
