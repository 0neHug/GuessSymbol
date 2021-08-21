using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject BlockPrefab;
    public int frameX, frameY;
    public float _offset = 3;
    private Vector3 spawnPoint;

    [SerializeField]
    public AllSymbols takeSymbol;
    private Symbols currentSymbol;

    [SerializeField]
    public AllLevels takeLevel;

    private ShowBlock[] inGameBlocks;

    private int countLevels = 0;



    public EndCanvasUi endScreen;
    void Awake()
    {
   
        SpawnBlocks();
        stateFromChose.nextLevel += SpawnBlocks;
    }

    void SpawnBlocks()

    {
        frameX = takeLevel.Levels[countLevels]._xRow;
        frameY = takeLevel.Levels[countLevels]._yRow;

        spawnPoint = new Vector3(this.transform.position.x - _offset * (frameX - 1) / 2, this.transform.position.y + _offset * (frameY - 1) / 2, 0f);

        inGameBlocks = GameObject.FindObjectsOfType<ShowBlock>();

        for (int i = 0; i < inGameBlocks.Length; i++)
        {
            Destroy(inGameBlocks[i].gameObject);
        }
        for (int i = 0; i < frameY; i++) 
        {
            for (int j = 0; j < frameX; j++)
            {

                currentSymbol = takeSymbol.LetterSymbols[Random.Range(0, takeSymbol.LetterSymbols.Count)];


                while (currentSymbol.stateAnswer == true)
                {
                    currentSymbol = takeSymbol.LetterSymbols[Random.Range(0, takeSymbol.LetterSymbols.Count)];
                }
                GameObject currentBlock = Instantiate(BlockPrefab, spawnPoint, Quaternion.identity);
                currentBlock.GetComponent<SpriteRenderer>().sprite = currentSymbol.Icon;
                currentBlock.name = currentSymbol.name;
                

                takeSymbol.addSymbol(currentSymbol);
                takeSymbol.LetterSymbols.RemoveAll(r=> r.name == currentSymbol.name);

                spawnPoint -= new Vector3(-_offset, 0f, 0f);                  
            }

            spawnPoint -= new Vector3(_offset * frameX, _offset, 0f);
        }

        spawnPoint -= new Vector3(0f, -_offset*frameY, 0f);
        takeSymbol.choseCorrect();

        if (countLevels >= takeLevel.Levels.Count-1)
        {
            Debug.Log(countLevels);
            countLevels=0;
            endScreen.Setup();
        }
            
        countLevels++;
            



    }

}
