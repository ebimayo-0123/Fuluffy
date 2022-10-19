using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

    }
    public void OnButtonClick()
    {
        if(ProbabilityInput.probability>0&&ProbabilityInput.probability<101)
        {
            if(SelectStage1.a)
            {
                SelectStage1.a=false;
                SceneManager.LoadScene("Stage1");
            }
            else if(SelectStage2.a)
            {
                SelectStage2.a=false;
                SceneManager.LoadScene("Stage2");
            }
            else if(SelectStage3.a)
            {
                SelectStage3.a=false;
                SceneManager.LoadScene("Stage3");
            }
            
        }
    }
}
