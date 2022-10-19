using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class DisplayButton : MonoBehaviour
{
    [SerializeField] GameObject title;
    [SerializeField] GameObject button1;
    [SerializeField] GameObject button2;
    [SerializeField] GameObject button3;
    int i=0;
 
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)&&i==0)
        {
           Destroy(title); 
            //ゲームオブジェクト非表示→表示
           title.SetActive(true);
           button1.SetActive(true);
           button2.SetActive(true);
           button3.SetActive(true);
           i=1;
        }
    }
}
