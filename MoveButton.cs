using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour
{
    public AudioSource audioSource;
    private GameObject su;
    public GameObject st;//선택 타일 
    public GameObject bb;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();//사운드
    }
    void Update()
    {
        su = GameObject.Find(MainControl.Instance.su);//su에 선택된 게임 오브젝트 가져옴

        
    }
    private void OnMouseDown()
    {

        audioSource.Play();
        Instantiate(bb, new Vector3((float)(su.transform.position.x), (float)(su.transform.position.y + 0.3), -3), Quaternion.identity);
        MainControl.Instance.act = "move";
        if (MainControl.Instance.su == "RTL")//기마병일경우 3칸 이동 타일 생성
        {
            Instantiate(st, new Vector2((float)(su.transform.position.x), (float)(su.transform.position.y + 4.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x), (float)(su.transform.position.y + 3)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x), (float)(su.transform.position.y + 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x-3), (float)(su.transform.position.y + 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x-1.5), (float)(su.transform.position.y + 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x-1.5), (float)(su.transform.position.y + 3)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 3), (float)(su.transform.position.y + 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y + 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y + 3)), Quaternion.identity);

            Instantiate(st, new Vector2((float)(su.transform.position.x), (float)(su.transform.position.y - 4.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x), (float)(su.transform.position.y - 3)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x), (float)(su.transform.position.y - 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 3), (float)(su.transform.position.y - 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y - 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y - 3)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 3), (float)(su.transform.position.y - 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 1.5), (float)(su.transform.position.y - 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 1.5), (float)(su.transform.position.y - 3)), Quaternion.identity);

            Instantiate(st, new Vector2((float)(su.transform.position.x+4.5), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x+3), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x+1.5), (float)(su.transform.position.y )), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 4.5), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 3), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 1.5), (float)(su.transform.position.y)), Quaternion.identity);

        }
        else if (MainControl.Instance.su == "BTL")//기마병일경우 3칸 이동 타일 생성
        {
            Instantiate(st, new Vector2((float)(su.transform.position.x), (float)(su.transform.position.y + 4.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x), (float)(su.transform.position.y + 3)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x), (float)(su.transform.position.y + 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 3), (float)(su.transform.position.y + 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 1.5), (float)(su.transform.position.y + 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 1.5), (float)(su.transform.position.y + 3)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 3), (float)(su.transform.position.y + 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y + 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y + 3)), Quaternion.identity);

            Instantiate(st, new Vector2((float)(su.transform.position.x), (float)(su.transform.position.y - 4.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x), (float)(su.transform.position.y - 3)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x), (float)(su.transform.position.y - 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 3), (float)(su.transform.position.y - 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y - 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y - 3)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 3), (float)(su.transform.position.y - 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 1.5), (float)(su.transform.position.y - 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 1.5), (float)(su.transform.position.y - 3)), Quaternion.identity);

            Instantiate(st, new Vector2((float)(su.transform.position.x + 4.5), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 3), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 4.5), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 3), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 1.5), (float)(su.transform.position.y)), Quaternion.identity);
        }
        else if (MainControl.Instance.su == "BTA")//암살자일경우 2칸 이동 타일 생성
        {
            Instantiate(st, new Vector2((float)(su.transform.position.x - 3), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 1.5), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 3), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x ), (float)(su.transform.position.y+3)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x ), (float)(su.transform.position.y+1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x ), (float)(su.transform.position.y-1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x ), (float)(su.transform.position.y-3)), Quaternion.identity);

            Instantiate(st, new Vector2((float)(su.transform.position.x - 1.5), (float)(su.transform.position.y-1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 1.5), (float)(su.transform.position.y+1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y+1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y-1.5)), Quaternion.identity);

        }
        else if (MainControl.Instance.su == "RTA")//암살자일경우 2칸 이동 타일 생성
        {
            Instantiate(st, new Vector2((float)(su.transform.position.x - 3), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 1.5), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 3), (float)(su.transform.position.y)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x), (float)(su.transform.position.y + 3)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x), (float)(su.transform.position.y + 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x), (float)(su.transform.position.y - 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x), (float)(su.transform.position.y - 3)), Quaternion.identity);

            Instantiate(st, new Vector2((float)(su.transform.position.x - 1.5), (float)(su.transform.position.y - 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 1.5), (float)(su.transform.position.y + 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y + 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y - 1.5)), Quaternion.identity);
        }
        else //나머지 유닛은 1칸이동
        {
            Instantiate(st, new Vector2((float)(su.transform.position.x + 1.5), (float)(su.transform.position.y )), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x - 1.5), (float)(su.transform.position.y )), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x ), (float)(su.transform.position.y - 1.5)), Quaternion.identity);
            Instantiate(st, new Vector2((float)(su.transform.position.x ), (float)(su.transform.position.y + 1.5)), Quaternion.identity);

        }
        Destroy(GameObject.Find("ａｔｔａｃｋ　ｂｕｔｔｏｎ(Clone)"));
        Destroy(GameObject.Find("ｍｏｖｅ　ｂｕｔｔｏｎ(Clone)"));
        Destroy(GameObject.Find("ｂａｃｋ　ｂｕｔｔｏｎ(Clone)"));
    }
}
