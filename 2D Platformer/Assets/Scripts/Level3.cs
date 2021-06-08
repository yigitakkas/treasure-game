using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Elma;
    public GameObject Muz;
    public GameObject Kiraz;
    public GameObject Uzum;
    public GameObject Cilek;
    public GameObject startS;
    public GameObject AciklamaS;
    public GameObject FailS;


    void Start()
    {
        

        startS = GameObject.Find("StartSpeach");
        AciklamaS = GameObject.Find("Acýklama");
        FailS = GameObject.Find("FailSpeach");

        AciklamaS.SetActive(false);
        FailS.SetActive(false);

        Invoke("Konusma",10);
        Invoke("Goster",5);
        Invoke("Gizle",9);

    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {

        
        if (collision.gameObject.name=="Cilek Kutusu")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        else if(collision.gameObject.name!="Cilek Kutusu")
        {
            FailS.SetActive(true);
            AciklamaS.SetActive(false);
        }
        

    }

    void Goster()
    {
        Elma.SetActive(true); ;
        Muz.SetActive(true); ;
        Kiraz.SetActive(true); ;
        Uzum.SetActive(true); ;
        Cilek.SetActive(true); ;
    }

    void Gizle()
    {
        Elma.SetActive(false);
        Muz.SetActive(false);
        Kiraz.SetActive(false);
        Uzum.SetActive(false);
        Cilek.SetActive(false);
    }


    void Konusma()
    {
        AciklamaS.SetActive(true);
        startS.SetActive(false);
    }
}
