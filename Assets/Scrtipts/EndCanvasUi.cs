
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
using System.Collections.Generic;

public class EndCanvasUi : MonoBehaviour
{
    [SerializeField]
    public List<Symbols> Symbols = new List<Symbols>();

    public Button _restartButton;
    public Image imageBackground;
    

    public Color EndColor;
    public void Setup()
    {
        gameObject.SetActive(true);
        imageBackground.DOColor(EndColor,1f);
        for (int i = 0; i < Symbols.Count; i++)
        {
            Symbols[i].stateAnswer = false;
            
        }

    }

    public void RestartScene()

    {
        
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }
}
