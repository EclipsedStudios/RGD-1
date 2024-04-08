using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private GameObject playerPosition;
    // Start is called before the first frame update

    public GameObject canvas;
    private bool hasPlayer;

    void Start()
    {
        canvas = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (hasPlayer && Input.GetKeyDown("f"))
        {
            canvas.SetActive(true);
        }
    }




    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player")) 
        {
            hasPlayer = true;
        }
    }
 
    private void OnTriggerExit(Collider other) 
    {
        if (other.CompareTag("Player")) 
        {
            hasPlayer = false;
        }
    }
}
