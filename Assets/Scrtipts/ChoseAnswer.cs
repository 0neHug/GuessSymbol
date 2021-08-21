using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChoseAnswer : MonoBehaviour
{
    

    public delegate void ClickAction(GameObject clicked);

    public static event ClickAction _chosen;
    public void OnMouseUp()
    {

        
        _chosen?.Invoke(this.gameObject);

    }
}
