using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;



public class stateFromChose : MonoBehaviour
    {
    public AllSymbols takeSymbol;

    public delegate void LevelAction();

    public static event LevelAction nextLevel;
    void Awake()
    {
        ChoseAnswer._chosen += Shake;
    }
    public void Shake(GameObject shaked)
    {
        if (takeSymbol.correctSymbol.nameSymbol + "_SymbolData" != shaked.name)
        {
            shaked.transform.DOShakePosition(0.3f, new Vector3(1f, 0f, 0f));
            Debug.Log(takeSymbol.correctSymbol.nameSymbol + "_SymbolData" );
        }
        else 
        {
            Debug.Log(takeSymbol.correctSymbol.nameSymbol + "_SymbolData" );
            nextLevel?.Invoke();
        }
    }
}
