using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
   
    private GameObject ObjGameOverUI;
    private GameObject OrgObjGameOverUI;
    private GameObject DiaObjGameOverUI;

    void Start()
    {
        ObjGameOverUI = GameObject.Find("SettingCanvas");
        OrgObjGameOverUI =GameObject.Find("Canvas");
        DiaObjGameOverUI =GameObject.Find("DialogCanvas");


        ObjGameOverUI.SetActive(false);
    }

    public void toSetting()
    {      
        ObjGameOverUI.SetActive(true); 
        OrgObjGameOverUI.SetActive(false);
        DiaObjGameOverUI.SetActive(false);
        Time.timeScale = 0;
    }

    public void toGame()
    {
        ObjGameOverUI.SetActive(false);
        OrgObjGameOverUI.SetActive(true);
        DiaObjGameOverUI.SetActive(true);
        Time.timeScale = 1;
    }

    public void exitGame()
    {
        Application.Quit();
    }
    //-------------------------------------------------------------

    
}
