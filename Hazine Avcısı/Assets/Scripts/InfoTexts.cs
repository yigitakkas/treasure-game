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
            if (infoText.activeSelf)
            {
                infoText.SetActive(false);
            }
            else
            {
                infoText.SetActive(true);
            }
        }
    }



}
