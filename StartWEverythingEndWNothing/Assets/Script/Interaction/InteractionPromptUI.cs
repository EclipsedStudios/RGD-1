using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//This script will keep the UI facing the camera instead of changing direction
public class InteractionPromptUI : MonoBehaviour
{

    private Camera mainCam;
    [SerializeField] private GameObject uiPanel;
    [SerializeField] private TextMeshProUGUI promptText;

    private void Start()
    {
        mainCam = Camera.main;
        uiPanel.SetActive(false); // turns the canvas off
    }

    private void LateUpdate()
    {
        var rotation = mainCam.transform.rotation;
        transform.LookAt(worldPosition: transform.position + rotation * rotation * Vector3.forward,
            worldUp: rotation * Vector3.up);
    }
    public bool IsDisplayed = false;

    public void SetUp(string _promptText)
    {
        promptText.text = _promptText;
        uiPanel.SetActive(true);
        IsDisplayed = true;
    }

    public void Close()
    {
        uiPanel.SetActive(false);
        IsDisplayed = false;
    }
}

