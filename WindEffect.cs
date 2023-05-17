using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindEffect : MonoBehaviour
{
    public AudioClip wind;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name=="Player")
        {
            GetComponent<AudioSource>().PlayOneShot(wind);
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
