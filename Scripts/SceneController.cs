using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TransTest1(){
        SceneManager.LoadScene("TestScene1");
    }

    public void TransTest2(){
        SceneManager.LoadScene("TestScene2");
    }

    public void TransTest3(){
        SceneManager.LoadScene("TestScene3");
    }
}
