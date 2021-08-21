using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "_SymbolData", menuName = "Symbols/Symbol")]
public class Symbols : ScriptableObject
{
    public string nameSymbol = "Symbol";
    public Sprite Icon;
    public bool stateAnswer;
}
