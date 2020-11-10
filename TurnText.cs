using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnText : MonoBehaviour
{
    public Text text;
    private string turn;
   
    void Update()
    { 
        turn= MainControl.Instance.turn;
        text.text = string.Format("{0}", MainControl.Instance.turn);
    }
}
