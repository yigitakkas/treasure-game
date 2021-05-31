using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    float x; 
    float y; 

    private void Start()
    {
        GameObject[] Instruments = GameObject.FindGameObjectsWithTag("Instrument");
        GameObject[] Notes = GameObject.FindGameObjectsWithTag("Note");
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



    }
}
