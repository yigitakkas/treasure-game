using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Elma;
    public GameObject Muz;
    public GameObject Kiraz;
    public GameObject Uzum;
    public GameObject Cilek;


    void Start()
    {
        Invoke("Goster", 2);
        Invoke("Gizle", 7);

    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {

        
        if (collision.gameObject.name=="Elma Kutusu")
        {
            Destroy(collision.gameObject);

        }
        if (Elma==null && collision.gameObject.name=="Muz Kutusu")
        {
            Destroy(collision.gameObject);
        }
        if(Elma==null && Muz==null &&collision.gameObject.name=="Uzum Kutusu")
        {
            Destroy(collision.gameObject);
            Debug.Log("Bölüm Tamamlandý.");
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
}
