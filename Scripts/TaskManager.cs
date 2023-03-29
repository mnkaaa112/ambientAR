using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    [SerializeField] GameObject rightController;
    // string cubeTag = "";
    int cubeLayer = 1<<3;
    int holeLayer = 1<<6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //レイに当たった物体をつかむ処理
        if(OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            RaycastHit hit;
            if(Physics.Raycast(rightController.transform.position,rightController.transform.forward, out hit, 100.0f, cubeLayer)){
                hit.collider.transform.parent = rightController.transform;
                // cubeTag = hit.collider.tag;
                // Debug.Log(cubeTag);
            }
        }

        //物体を離す処理        
        if(OVRInput.GetUp(OVRInput.Button.SecondaryIndexTrigger))
        {
            for(int i=0;i<rightController.transform.childCount;i++)
            {
                var child = rightController.transform.GetChild(i);
                if(child.tag == "Pink" || child.tag == "Yellow" || child.tag == "Blue")
                {
                    child.parent = null;
                }
            }
        }
    }
        

}
