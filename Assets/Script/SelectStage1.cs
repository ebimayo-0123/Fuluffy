using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SelectStage1 : MonoBehaviour
{
    static public bool a=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnButtonClick()
    {
        a=true;
        SceneManager.LoadScene("Probability");
    }
}
