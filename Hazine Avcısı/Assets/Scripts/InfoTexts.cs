using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoTexts : MonoBehaviour
{
    public GameObject infoText;
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            infoText.SetActive(true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            infoText.SetActive(false);
        }
    }



}
