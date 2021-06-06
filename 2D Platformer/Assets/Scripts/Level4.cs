using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4 : MonoBehaviour
{

    public GameObject monkey;
    public GameObject monkey2;
    public GameObject croc;
    public GameObject croc2;
    public GameObject snake;
    public GameObject snake2;
    public GameObject bear;
    public GameObject bear2;
    public GameObject monkeyCard;
    public GameObject monkey2Card;
    public GameObject crocCard;
    public GameObject croc2Card;
    public GameObject snakeCard;
    public GameObject snake2Card;
    public GameObject bearCard;
    public GameObject bear2Card;
    GameObject temp;
    List<GameObject> cards = new List<GameObject>();
    List<GameObject> animals = new List<GameObject>();

    private void Start()
    {
        cards.Add(monkeyCard);
        cards.Add(monkey2Card);
        cards.Add(crocCard);
        cards.Add(croc2Card);
        cards.Add(snakeCard);
        cards.Add(snake2Card);
        cards.Add(bearCard);
        cards.Add(bear2Card);

        animals.Add(monkey);
        animals.Add(monkey2);
        animals.Add(croc);
        animals.Add(croc2);
        animals.Add(snake);
        animals.Add(snake2);
        animals.Add(bear);
        animals.Add(bear2);
        
        
        Invoke("Gizle",1);
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Cave")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (temp != null)
        {
            
            if (collision.name == "Card_croc" && temp.transform.position!=collision.transform.position)
            {
                croc.SetActive(true);
                if (temp.name == croc.name)
                {
                    Destroy(crocCard);
                    Destroy(croc2Card);

                    Destroy(GameObject.Find("Ani_crocodile"));
                    temp = null;
                    Invoke("Gizle", 0.5f);
                }
                else
                {
                    Invoke("Gizle", 0.5f);
                    temp = null;
                }
            }
        
            if (collision.name == "Card_croc_2" && temp.transform.position != collision.transform.position)
            {
                croc2.SetActive(true);
                if (temp.name == croc2.name)
                {
                    Destroy(crocCard);
                    Destroy(croc2Card);

                    Destroy(GameObject.Find("Ani_crocodile"));
                    temp = null;
                    Invoke("Gizle", 0.5f);
                }
                else
                {
                    Invoke("Gizle", 0.5f);
                    temp = null;
                }
            }
            if (collision.name == "Card_monkey" && temp.transform.position != collision.transform.position)
            {
                monkey.SetActive(true);
                if (temp.name == monkey.name)
                {
                    Destroy(monkeyCard);
                    Destroy(monkey2Card);
                    temp = null;
                    Invoke("Gizle", 0.5f);
                    Destroy(GameObject.Find("Ani_monkey"));
                }
                else
                {
                    Invoke("Gizle", 0.5f);
                    temp = null;
                }
            }
            if (collision.name == "Card_monkey_2" && temp.transform.position != collision.transform.position)
            {
                monkey2.SetActive(true);
                if (temp.name == monkey2.name)
                {
                    Destroy(monkeyCard);
                    Destroy(monkey2Card);
                    temp = null;
                    Invoke("Gizle", 0.5f);
                    Destroy(GameObject.Find("Ani_monkey"));
                }
                else
                {
                    Invoke("Gizle", 0.5f);
                    temp = null;
                }
            }
            if (collision.name == "Card_snake" && temp.transform.position != collision.transform.position)
            {
                snake.SetActive(true);
                if (temp.name == snake.name)
                {
                    Destroy(snakeCard);
                    Destroy(snake2Card);
                    temp = null;
                    Invoke("Gizle", 0.5f);
                    Destroy(GameObject.Find("Ani_snake"));
                }
                else
                {
                    Invoke("Gizle", 0.5f);
                    temp = null;
                }
            }
            if (collision.name == "Card_snake_2" && temp.transform.position != collision.transform.position)
            {
                snake2.SetActive(true);
                if (temp.name == snake2.name)
                {
                    Destroy(snakeCard);
                    Destroy(snake2Card);
                    temp = null;
                    Invoke("Gizle", 0.5f);
                    Destroy(GameObject.Find("Ani_snake"));
                }
                else
                {
                    Invoke("Gizle", 0.5f);
                    temp = null;
                }
            }
            if (collision.name == "Card_bear" && temp.transform.position != collision.transform.position)
            {
                bear.SetActive(true);
                if (temp.name == bear.name)
                {
                    
                    temp = null;
                    Invoke("Gizle", 0.5f);
                    Destroy(bearCard);
                    Destroy(bear2Card);
                    Destroy(GameObject.Find("Ani_bear"));
                }
                else
                {
                    Invoke("Gizle", 0.5f);
                    temp = null;
                }
            }
            if (collision.name == "Card_bear_2" && temp.transform.position != collision.transform.position)
            {
                bear2.SetActive(true);
                if (temp.name == bear2.name)
                {
                    
                    Invoke("Gizle", 0.5f);
                    Destroy(bearCard);
                    Destroy(bear2Card);
                    temp = null;
                    Destroy(GameObject.Find("Ani_bear"));
                }
                else
                {
                    Invoke("Gizle", 0.5f);

                    temp = null;
                }
            }
        }
        else
        {
            if (collision.name == "Card_croc" )
            {
                croc.SetActive(true);
                temp = croc;
            }
            if (collision.name == "Card_croc_2")
            {
                croc2.SetActive(true);
                temp = croc2;
            }
            if (collision.name == "Card_monkey")
            {
                monkey.SetActive(true);
                temp = monkey;
            }
            if (collision.name == "Card_monkey_2")
            {
                monkey2.SetActive(true);
                temp = monkey2;
            }
            if (collision.name == "Card_snake")
            {
                snake.SetActive(true);
                temp = snake;
            }
            if (collision.name == "Card_snake_2")
            {
                snake2.SetActive(true);
                temp = snake2;
            }
            if (collision.name == "Card_bear")
            {
                bear.SetActive(true);
                temp = bear;
            }
            if (collision.name == "Card_bear_2")
            {
                bear2.SetActive(true);
                temp = bear2;
            }
        }

    }


   

    void Gizle()
    {
        foreach (GameObject animal in animals)
        {
            if (animal != null)
            {
                animal.SetActive(false);
            }
                
        }


    }

    

    

}
