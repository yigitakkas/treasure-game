using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{

    GameObject Sax;
    GameObject SaxNote;
    GameObject Drum;
    GameObject DrumNote;
    GameObject Guitar;
    GameObject GuitarNote;
    GameObject Violin;
    GameObject ViolinNote;
    GameObject[] Notes;
    float x; 
    float y;
    int noteCounter=0;

    private void Start()
    {
        GameObject[] Instruments = GameObject.FindGameObjectsWithTag("Instrument");
        Notes = GameObject.FindGameObjectsWithTag("Note");
        Sax = Instruments[0];
        SaxNote = Notes[0];
        Guitar = Instruments[1];
        GuitarNote = Notes[1];
        Drum = Instruments[2];
        DrumNote = Notes[2];
        Violin = Instruments[3];
        ViolinNote = Notes[3];


    }


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
            noteCounter++;
        }

        if (Guitar != null && GuitarNote != null)
        {
            x = Guitar.transform.position.x - GuitarNote.transform.position.x;
            y = Guitar.transform.position.y - GuitarNote.transform.position.y;
        }

        if ((x < 1 && x > -1) && (y - 1 < 0 && y > -1))
        {
            
            Destroy(GuitarNote);
            noteCounter++;
        }
        if (Drum != null && DrumNote != null)
        {
            x = Drum.transform.position.x - DrumNote.transform.position.x;
            y = Drum.transform.position.y - DrumNote.transform.position.y;
        }

        if (  (x < 1 && x>-1) && (y - 1 < 0 && y > -1))
        {
           
            Destroy(DrumNote);
            noteCounter++;
        }
        if (Violin != null&& ViolinNote!=null)
        {
            x = Violin.transform.position.x - ViolinNote.transform.position.x;
            y = Violin.transform.position.y - ViolinNote.transform.position.y;
            
            
            
        }

        if ((x < 1 && x > -1) && (y - 1 < 0 && y > -1))
        {
            
            Destroy(ViolinNote);
            noteCounter++;
        }
        Debug.Log(noteCounter);
        
        if (noteCounter >= 6)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }

    
}
