using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTA_LIFE : MonoBehaviour//자기 주인 체력에 따라 이미지 바뀌는코드
{
    private SpriteRenderer spr;
    public Sprite[] sprites;
    void Start()
    {
        
        spr = GetComponent<SpriteRenderer>();//스프라이트 렌더러 가져온다!
        BTA bta_life = GameObject.Find("BTA").GetComponent<BTA>();//주인의 체력 가져온다!
    }

    // Update is called once per frame
    void Update()
    {
        if (BTA.bta_life==1) 
        {
            spr.sprite = sprites[0];
        }
        else if(BTA.bta_life==2)
        {
            spr.sprite = sprites[1];
        }
        else if (BTA.bta_life == 3)
        {
            spr.sprite = sprites[2];
        }
        else if (BTA.bta_life == 4)
        {
            spr.sprite = sprites[3];
        }
        else if (BTA.bta_life == 5)
        {
            spr.sprite = sprites[4];
        }
    }
}
