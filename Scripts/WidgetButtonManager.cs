using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WidgetButtonManager : MonoBehaviour
{
    public GameObject MenuCanvas;
    public GameObject WeatherPanel;
    public GameObject SchedulePanel;
    public GameObject TaskPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuButtonPressed(){
        if(MenuCanvas.activeSelf){
            MenuCanvas.SetActive(false);
        }else{
            MenuCanvas.SetActive(true);
            WeatherPanel.SetActive(false);
            SchedulePanel.SetActive(false);
            TaskPanel.SetActive(false);
        }
        
    }

    public void WeatherButtonPressed(){
        MenuCanvas.SetActive(false);
        WeatherPanel.SetActive(true);

    }

    public void ScheduleButtonPressed(){
        MenuCanvas.SetActive(false);
        SchedulePanel.SetActive(true);
    }

    public void TaskButtonPressed(){
        MenuCanvas.SetActive(false);
        TaskPanel.SetActive(true);
    }

    public void CloseButtonPressed(){
        MenuCanvas.SetActive(true);
        WeatherPanel.SetActive(false);
        SchedulePanel.SetActive(false);
        TaskPanel.SetActive(false);
    }
}
