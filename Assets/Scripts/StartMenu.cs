using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public GameObject targetObject;
    private void Start()
    {
        targetObject.SetActive(true);
        Time.timeScale = 0f;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Return))
        {
            targetObject.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }
}