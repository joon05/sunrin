using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTM_LIFE : MonoBehaviour
{
    private SpriteRenderer spr;
    public Sprite[] sprites;
    void Start()
    {

        spr = GetComponent<SpriteRenderer>();//스프라이트 렌더러 가져온다!

    }

    // Update is called once per frame
    void Update()
    {
        if (RTM.rtm_life == 1)
        {
            spr.sprite = sprites[0];
        }
        else if (RTM.rtm_life == 2)
        {
            spr.sprite = sprites[1];
        }
        else if (RTM.rtm_life == 3)
        {
            spr.sprite = sprites[2];
        }
        else if (RTM.rtm_life == 4)
        {
            spr.sprite = sprites[3];
        }
        else if (RTM.rtm_life == 5)
        {
            spr.sprite = sprites[4];
        }
    }
}
