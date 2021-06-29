using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{

    public GameObject Sax;
    public GameObject SaxNote;
    public GameObject Drum;
    public GameObject DrumNote;
    public GameObject Guitar;
    public GameObject GuitarNote;
    public GameObject Violin;
    public GameObject ViolinNote;
    float x; 
    float y;

    


    private void Update()
    {
        if (Sax != null && SaxNote != null)
        {
            x = Sax.transform.position.x - SaxNote.transform.position.x;
            y = Sax.transform.position.y - SaxNote.transform.position.y;
        }
        
        if ((x < 1 && x > -1) && (y - 1 < 0 && y > -1))
        {
            
            Destroy(SaxNote);
        }

        if (Guitar != null && GuitarNote != null)
        {
            x = Guitar.transform.position.x - GuitarNote.transform.position.x;
            y = Guitar.transform.position.y - GuitarNote.transform.position.y;
        }

        if ((x < 1 && x > -1) && (y - 1 < 0 && y > -1))
        {
            
            Destroy(GuitarNote);
        }
        if (Drum != null && DrumNote != null)
        {
            x = Drum.transform.position.x - DrumNote.transform.position.x;
            y = Drum.transform.position.y - DrumNote.transform.position.y;
        }

        if (  (x < 1 && x>-1) && (y - 1 < 0 && y > -1))
        {
           
            Destroy(DrumNote);
        }
        if (Violin != null&& ViolinNote!=null)
        {
            x = Violin.transform.position.x - ViolinNote.transform.position.x;
            y = Violin.transform.position.y - ViolinNote.transform.position.y;
            
            
            
        }

        if ((x < 1 && x > -1) && (y - 1 < 0 && y > -1))
        {
            
            Destroy(ViolinNote);
        }

        Invoke("nextLevel",1);

    }

    
    void nextLevel()
    {
        if (ViolinNote == null && GuitarNote == null && DrumNote == null && SaxNote == null) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
       
    }
}
