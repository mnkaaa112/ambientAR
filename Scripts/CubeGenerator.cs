using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject PinkPrefab;
    public GameObject BluePrefab;
    public GameObject YellowPrefab;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if(counter==150){
            counter = 0;
            CubeGenerate();
        }
    }

    void CubeGenerate(){
        int color = Random.Range(1,4);
        float x = Random.Range(-4,5);
        int position = Random.Range(1,5);
        Vector3 p;
        if(position == 1){
            p = new Vector3(x, -3.0f, 7.0f);
        }else if(position == 2){
            p = new Vector3(x, -2.3f, 7.5f);
        }else if(position == 3){
            p = new Vector3(x, -1.5f, 8.0f);
        }else{
            p = new Vector3(x, -0.6f, 8.0f);
        }

        if(color == 1){
            Instantiate(PinkPrefab, p, Quaternion.identity);
        }else if(color == 2){
            Instantiate(BluePrefab, p, Quaternion.identity);
        }else{
            Instantiate(YellowPrefab, p, Quaternion.identity);
        }
    }

    public void StopGenerate(){
        this.gameObject.SetActive(false);
    }
}
