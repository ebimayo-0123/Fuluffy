using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player2 : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float jumpForce = 300f;
    public GameObject title;
    //[SerializeField] private TMP_Text Text = GameObject.Find("Text");
    public TextMeshProUGUI Text;
    public TextMeshProUGUI Scoretext;
    private int i, score=0;
    static public int answer=0, a=0, c=0;
    private string str;

    // Start is called before the first frame update
    void Start()
    {
        rb2d.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(rb2d.isKinematic==true)//É^ÉCÉgÉãÇ™Ç†ÇÈèÛë‘
            {
                rb2d.isKinematic = false;
                Scoretext.text=string.Format("score:{0}", score);
            }
            rb2d.velocity = Vector3.zero;
            rb2d.AddForce(Vector3.up * jumpForce);
        }

        if(c == 0)
        {
            c = Random.Range(4, 19);
            str = c.ToString();
            Text.text = "ÅZ + ÅZ = " + str;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        for(i=1; i<=30; i++)
        {
            string tmp=i.ToString();
            if(collision.gameObject.CompareTag(tmp))
            {
                if(a==0 && i<c){
                    Text.text=tmp+" +  ÅZ = "+str;
                    a=i;
                    answer = c-a;
                }
                else if(i==answer){

                    Text.text=a+" + "+tmp+" = " + str;
                    a=0;
                    c=0;
                    answer=0;
                    score+=10;
                    Scoretext.text=string.Format("score:{0}", score);
                }
                collision.gameObject.SetActive(false);
            }   
        }
    }
}
