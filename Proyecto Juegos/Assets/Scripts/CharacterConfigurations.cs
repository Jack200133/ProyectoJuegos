using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterConfigurations : MonoBehaviour
{
    public GameObject[] spawns;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemie"))
        {

            gameObject.transform.position = spawns[Random.Range(0, 3)].transform.position;


        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Light")) {

            gameObject.tag = "onLight";
        
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Light"))
        {

            print("onLight");

            gameObject.tag = "notOnLight";
        }
    }
}
