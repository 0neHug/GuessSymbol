using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FindAnswer : MonoBehaviour
{
    public AllSymbols takeSymbol;
    public Text textQuestion;
    float duration = 2.0f;
    float lerp = 0f;

    public Color StartColor, EndColor;
    
    void Awake()
    {

        textQuestion = GetComponent<Text>();
        

    }

 
    void Update()
    {
        textQuestion.text = "Find - " + takeSymbol.correctSymbol.nameSymbol;

        if (lerp > 0.9) { lerp = 1f; } else { lerp = Mathf.PingPong(Time.time, duration) / duration; }
        textQuestion.color = Color.Lerp(StartColor, EndColor, lerp);
      

        


    }
}
