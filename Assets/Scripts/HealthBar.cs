using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Slider slider;
    public Vector3 Offset;

    public void Start()
    {
        slider.enabled = true;
        SetHealth(1000, 1000);
    }

    public void SetHealth(float hp, float maxhp)
    {
        slider.value = hp;
        slider.maxValue = maxhp;
    }


    private void Update()
    {
        slider.value--;

        if (slider.value <= 0)
        {
            Destroy(transform.parent.parent.gameObject);
        }
    }
}
