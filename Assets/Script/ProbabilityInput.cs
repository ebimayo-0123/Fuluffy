using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ProbabilityInput : MonoBehaviour
{
    public InputField input;
    static public int probability=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ValueChange (string text)
    {
        probability = Int32.Parse(text);
        //Debug.Log(text);
        //Debug.Log(probability);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
