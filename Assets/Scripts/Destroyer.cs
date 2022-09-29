using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If the GameObject that has collided with our trigger is tagged with cleanup
        if (collision.gameObject.tag == "CleanUp" || collision.gameObject.tag == "Collectibles")
        {
            //Then we use this method to destroy it
            Destroy(collision.gameObject);

        }
    }
}
