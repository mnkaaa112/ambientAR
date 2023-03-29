using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == this.gameObject.tag){
            Destroy(this.gameObject);
        }
    }
}
