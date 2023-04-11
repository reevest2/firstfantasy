using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Slider slider;
    public Vector3 Offset;

    public void Start()
    {
        slider.enabled = true;
        SetHealth(80, 100);
    }

    public void SetHealth(float hp, float maxhp)
    {
        slider.value = hp;
        slider.maxValue = maxhp;
    }


    private void Update()
    {

    }
}
