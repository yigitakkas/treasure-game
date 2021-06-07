using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level5 : MonoBehaviour
{
    public GameObject b8;
    public GameObject b9;
    public GameObject b11;

    private void Start()
    {

        b8.SetActive(false);
        b9.SetActive(false);
     
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name== "Tabela11" &&b11!=null)
        {
            Destroy(b11);
            b8.SetActive(true);
        }
        if (collision.name == "Tabela8" && b11==null &&b8!=null)
        {
            Destroy(b8);
            b9.SetActive(true);
        }
        if (collision.name == "Tabela9" && b8==null && b9!=null)
        {
            Destroy(b9);
            Destroy(GameObject.Find("Block"));
        }
        if (collision.name == "Door" && b9==null)
        {
            Debug.Log("Next Level");
        }
    }

}
