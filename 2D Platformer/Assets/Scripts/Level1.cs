using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    public GameObject bPotion;
    public GameObject rPotion;
    public GameObject yPotion;
    public GameObject kazan;
    bool kazanEmpty=true;


   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == bPotion.name && kazanEmpty)
        {
            kazanEmpty = false;
            Debug.Log("Blue");
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        if (collision.gameObject.name == yPotion.name && kazanEmpty)
        {
            kazanEmpty = false;
            Debug.Log("Yellow");
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (collision.gameObject.name == rPotion.name && kazanEmpty)
        {
            kazanEmpty = false;
            Debug.Log("Red");
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        if(!kazanEmpty&&kazan.GetComponent<Renderer>().material.color == Color.red && collision.gameObject.name == yPotion.name)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 0.5f, 0);//Orange
        }
        if (!kazanEmpty && kazan.GetComponent<Renderer>().material.color == Color.red && collision.gameObject.name == bPotion.name)
        {
            gameObject.GetComponent<Renderer>().material.color =new Color(1f,0f,1f);//Purple
        }
        if (!kazanEmpty && kazan.GetComponent<Renderer>().material.color == Color.yellow && collision.gameObject.name == bPotion.name)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(0, 1, 0);//Green
        }
        if (!kazanEmpty && kazan.GetComponent<Renderer>().material.color == Color.yellow && collision.gameObject.name == rPotion.name)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(1,0.5f,0);//Orange
        }
        if (!kazanEmpty && kazan.GetComponent<Renderer>().material.color == Color.blue && collision.gameObject.name == rPotion.name)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(1f, 0f, 1f);//Purple
        }
        if (!kazanEmpty && kazan.GetComponent<Renderer>().material.color == Color.blue && collision.gameObject.name == yPotion.name)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(0, 1, 0);//Green
        }



    }

}
