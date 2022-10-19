using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player1 : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float jumpForce = 300f;
    public GameObject title;
    //[SerializeField] private TMP_Text Text = GameObject.Find("Text");
    public TextMeshProUGUI Text;
    public TextMeshProUGUI Scoretext;
    private int a=0, b=0, c=0, i, score=0;
    static public int answer=0;

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
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*switch(collision.gameObject.Tag)
        {
            case "1":
                Text.text="1";
                break;

            case "2":
                Text.text="2";
                break;
            case "3":
                Text.text="3";
                break;
            case "4":
                Text.text="4";
                break;
            case "5":
                Text.text="5";
                break;
            case "6":
                Text.text="6";
                break;
            case "7":
                Text.text="7";
                break;
            case "8":
                Text.text="8";
                break;
            case "9":
                Text.text="9";
                break;
        }*/
        
        for(i=1; i<=30; i++)
        {
            string str=i.ToString();
            if(collision.gameObject.CompareTag(str))
            {
                if(a==0){
                    Text.text=str+" + ";
                    a=i;
                    collision.gameObject.SetActive(false);
                    break;
                }
                else if(b==0){
                    Text.text=a+" + "+str+" = ";
                    b=i;
                    collision.gameObject.SetActive(false);
                    break;
                }
                else if(a!=0&&b!=0){
                    c=i;
                    answer=a+b;
                    if(a+b==c)
                    {
                        Text.text=a+" + "+b+" = "+str;
                        score+=10;
                        Scoretext.text=string.Format("score:{0}", score);
                        a=0;
                        b=0;
                        answer=0;
                        collision.gameObject.SetActive(false);
                        break;
                    }
                }
                collision.gameObject.SetActive(false);
            }   
        }

        
        /*if(collision.gameObject.CompareTag("1"))
        {
            if(a==0){
                Text.text="1 + ";
                a=1;
            }
            else if(b==0){
                Text.text=a+" + 1 =";
                b=1;
            }
            else if(a!=0&&b!=0){
                c=1;
                if(a+b==c)
                {
                    Text.text=a+" + "+b+" = 1";
                    a=0;
                    b=0;
                }
            }
            collision.gameObject.SetActive(false);
        }

        if(collision.gameObject.CompareTag("2"))
        {
            if(a==0){
                Text.text="1 + ";
                a=2;
            }
            else if(b==0){
                Text.text=a+" + 1 =";
                b=2;
            }
            else if(a!=0&&b!=0){
                c=1;
                if(a+b==c)
                {
                    Text.text=a+" + "+b+" = 1";
                    a=0;
                    b=0;
                }
            }
            collision.gameObject.SetActive(false);
        }

        if(collision.gameObject.CompareTag("3"))
        {
            Text.text="3";
            collision.gameObject.SetActive(false);
        }

        if(collision.gameObject.CompareTag("4"))
        {
            Text.text="4";
            collision.gameObject.SetActive(false);
        }

        if(collision.gameObject.CompareTag("5"))
        {
            Text.text="5";
            collision.gameObject.SetActive(false);
        }

        if(collision.gameObject.CompareTag("6"))
        {
            Text.text="6";
            collision.gameObject.SetActive(false);
        }

        if(collision.gameObject.CompareTag("7"))
        {
            Text.text="7";
            collision.gameObject.SetActive(false);
        }

        if(collision.gameObject.CompareTag("8"))
        {
            Text.text="8";
            collision.gameObject.SetActive(false);
        }

        if(collision.gameObject.CompareTag("9"))
        {
            Text.text="9";
            collision.gameObject.SetActive(false);
        }*/
        
    }
}
