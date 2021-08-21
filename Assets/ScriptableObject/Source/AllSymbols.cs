using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AllSymbols : MonoBehaviour
{

    

    [SerializeField]  
    public List<Symbols> DigitSymbols = new List<Symbols>();

    [SerializeField]  
    public List<Symbols> LetterSymbols = new List<Symbols>();

    [SerializeField]
    public List<Symbols> inGameSymbols = new List<Symbols>();

    public Symbols correctSymbol;



    public void addSymbol(Symbols simbol)
    {
        inGameSymbols.Add(simbol);
        
    }

    public void choseCorrect()
    {
        correctSymbol = inGameSymbols[Random.Range(0, inGameSymbols.Count)];
        correctSymbol.stateAnswer = true;
        inGameSymbols.RemoveAll(r => r.stateAnswer == true);
        LetterSymbols.AddRange(inGameSymbols);
        inGameSymbols.Clear();
    }
}
