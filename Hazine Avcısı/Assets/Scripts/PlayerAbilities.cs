using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAbilities : MonoBehaviour
{

    public Transform grabDetect;
    public Transform boxHolder;
    public float rayDist;
    public float throwSpeed;

    public GameObject StartSpeach;
    public GameObject FailedSpeach;
    RaycastHit2D grabCheck;
    public bool isHolding = false;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDist);

        if (Input.GetKey(KeyCode.F))
        {
            GrabItem();
        }
        else if (Input.GetKey(KeyCode.G))
        {
            DropItem();
        }

        if (!grabCheck)
        {
            isHolding = false;
        }

    }
    void GrabItem()
    {
        
        if (grabCheck.collider != null && grabCheck.collider.tag == "Items"&& !isHolding)
        {

            grabCheck.collider.gameObject.transform.parent = boxHolder;
            grabCheck.collider.gameObject.transform.position = boxHolder.position;
            grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x, 1) * throwSpeed;
            isHolding = true;

        }
        

        else if(grabCheck.collider != null && grabCheck.collider.tag == "Note" && !isHolding)
        {
            grabCheck.collider.gameObject.transform.parent = boxHolder;
            grabCheck.collider.gameObject.transform.position = boxHolder.position;
            grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x, 1) * throwSpeed;
            isHolding = true;
            grabCheck.collider.gameObject.GetComponent<AudioSource>().Play();
        }
        
       

        
    }
    void DropItem()
    {
        if(grabCheck.collider != null && grabCheck.collider.tag == "Items" && isHolding)
        {
            grabCheck.collider.gameObject.transform.parent = null;
            grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            isHolding = false;
        }
        else if (grabCheck.collider != null && grabCheck.collider.tag == "Note" && isHolding)
        {
            grabCheck.collider.gameObject.transform.parent = null;
            grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            isHolding = false;
            grabCheck.collider.gameObject.GetComponent<AudioSource>().Stop();
        }


    }

}


