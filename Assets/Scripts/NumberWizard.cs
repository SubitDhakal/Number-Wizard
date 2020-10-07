using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
   [SerializeField] int min, max;
   [SerializeField] TextMeshProUGUI guessText;
   int guess ;

    // Start is called before the first frame update
    void Start()
    {

        StartGame();
    }


    void StartGame()
    {
        min = 1;
        max = 1000;
        NextGuess();
        
    }

    public void OnPressHigher()
    {
        min = guess-1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess+1;
        NextGuess();
    }

    public void Onclick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            NextGuess();
        }
    }
    void NextGuess()
    {
        guess = Random.Range(min,max+1);
        guessText.text = guess.ToString();
    }
}
