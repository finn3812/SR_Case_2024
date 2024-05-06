using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBarFIJ : MonoBehaviour
{
    public Image health;
    public float maxValue;
    public GameObject frame;
    void Start()
    {
        frame.SetActive(false);
    }

    public void SetupRange(float max)
    {
        maxValue = max;
        health.fillAmount = 1;
    }
    
    public void SetHealtBar(float HealthValue)
    {
        frame.SetActive(true);
        health.fillAmount= HealthValue / maxValue;
    }

    private void Update()
    {
        transform.LookAt(Camera.main.transform);
    }
}
