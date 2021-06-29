using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level6 : MonoBehaviour
{

    public GameObject marmara;
    public GameObject ege;
    public GameObject GD;
    public GameObject Dogu;
    public GameObject icAnadolu;
    public GameObject akdeniz;
    public GameObject karadeniz;

    private void Start()
    {
        ege.SetActive(false);
        GD.SetActive(false);
        Dogu.SetActive(false);
        icAnadolu.SetActive(false);
        akdeniz.SetActive(false);
        karadeniz.SetActive(false);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "MarmaraHarita" && marmara != null)
        {
            Destroy(marmara);
            ege.SetActive(true);
        }
        if (collision.name == "EgeHarita" && marmara == null && ege != null)
        {
            Destroy(ege);
            karadeniz.SetActive(true);
        }
        if (collision.name == "KaradenizHarita" && ege == null && karadeniz != null)
        {
            Destroy(karadeniz);
            GD.SetActive(true);
        }
        if (collision.name == "GD AnadoluHarita" && karadeniz == null && GD != null)
        {
            Destroy(GD);
            Dogu.SetActive(true);

        }
        if (collision.name == "D AnadoluHarita" && GD == null && Dogu != null)
        {
            Destroy(Dogu);
            akdeniz.SetActive(true);
        }
        if (collision.name == "AkdenizHarita" && Dogu == null && akdeniz != null)
        {
            Destroy(akdeniz);
            icAnadolu.SetActive(true);
        }
        if (collision.name == "нч AnadoluHarita" && akdeniz == null && icAnadolu != null)
        {
            Destroy(icAnadolu);
            Destroy(GameObject.Find("Block"));
        }
        if (collision.name == "Hazine")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
