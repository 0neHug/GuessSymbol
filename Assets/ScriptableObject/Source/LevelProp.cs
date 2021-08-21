using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "_LevelData", menuName = "Levels/Level")]
public class LevelProp : ScriptableObject
{
    public int _xRow;
    public int _yRow;
    
    public bool FinalLevel;
}
