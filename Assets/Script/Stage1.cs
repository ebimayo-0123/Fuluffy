using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1 : MonoBehaviour
{
    public GameObject n;
    public GameObject n1;
    public GameObject n2;
    public GameObject n3;
    public GameObject n4;
    public GameObject n5;
    public GameObject n6;
    public GameObject n7;
    public GameObject n8;
    public GameObject n9;
    public GameObject n10;
    public GameObject n11;
    public GameObject n12;
    public GameObject n13;
    public GameObject n14;
    public GameObject n15;
    public GameObject n16;
    public GameObject n17;
    public GameObject n18;
    public GameObject n19;
    public GameObject n20;
    public GameObject n21;
    public GameObject n22;
    public GameObject n23;
    public GameObject n24;
    public GameObject n25;
    public GameObject n26;
    public GameObject n27;
    public GameObject n28;
    public GameObject n29;
    public GameObject n30;
    GameObject[] ns;
    private int probability = ProbabilityInput.probability;

    public GameObject boom;
    private bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        ns = new GameObject[] {n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15, n16, n17, n18, n19, n20, n21, n22, n23, n24, n25, n26, n27, n28, n29, n30};
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        while (isAlive)
        {
            if(Player1.answer==0)
            {
                n = ns[Random.Range(0, 9)];//0~8
            }
            else
            {
                /*if(PlayerController.answer<=9)
                {
                    n = ns[Random.Range(0, 9)];
                }*/
                //else{
                    if(Random.Range(1, 101)<=probability)
                    {
                        n = ns[Player1.answer-1];
                    }
                    else{
                        n = ns[Random.Range(0, 19)];
                    }
                //}

            }
            //n = ns[Random.Range(0, 9)];

            float y = Random.Range(-4.5f, 4.5f);
            int direction = Random.Range(0, 2);

            if (direction == 0)
            {
                n.transform.position = new Vector3(3.0f, y, 0);
            }
            else
            {
                n.transform.position = new Vector3(-3.0f, y, 0);
            }

            Instantiate(n);
            yield return new WaitForSeconds(1.0f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject effect=Instantiate(boom, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(effect, 3);
            isAlive = false;
        }else
        {
            for(int i=1; i<=30; i++)
            {
                string str=i.ToString();
                if (collision.CompareTag(str))
                {
                    Destroy(collision.gameObject);
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
