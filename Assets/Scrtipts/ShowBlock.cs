using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ShowBlock : MonoBehaviour
{
    

    
    void Start()
    {
        
        var wakeUpSequence = DOTween.Sequence();

        wakeUpSequence.Append(transform.DOScale(new Vector3(0.5f, 0.5f, 1f), 0.2f));
        wakeUpSequence.Append(transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0f), Random.Range(0.5f,1f), 0, 1f));

        
    }
    
}
