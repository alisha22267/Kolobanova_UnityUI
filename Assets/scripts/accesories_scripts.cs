using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class accesories_scripts : MonoBehaviour
{
    public GameObject a1;
    public GameObject a2;
    public GameObject a3;
    public GameObject a4;
    public GameObject a5;
    public GameObject a6;
    public GameObject a7;
    public GameObject a8;
    public GameObject a9;
    public GameObject a10;

    public GameObject a1_toggle;
    public GameObject a2_toggle;
    public GameObject a3_toggle;
    public GameObject a4_toggle;
    public GameObject a5_toggle;
    public GameObject a6_toggle;
    public GameObject a7_toggle;
    public GameObject a8_toggle;
    public GameObject a9_toggle;
    public GameObject a10_toggle;

    public bool togglesVisible = false;

    void Start()
    {
        SetTogglesActive(false); // sākumā paslēpti
    }

    public void ToggleTogglesVisibility()
    {
        togglesVisible = !togglesVisible;
        SetTogglesActive(togglesVisible);
    }

    public void SetTogglesActive(bool isActive)
    {
        a1_toggle.SetActive(isActive);
        a2_toggle.SetActive(isActive);
        a3_toggle.SetActive(isActive);
        a4_toggle.SetActive(isActive);
        a5_toggle.SetActive(isActive);
        a6_toggle.SetActive(isActive);
        a7_toggle.SetActive(isActive);
        a8_toggle.SetActive(isActive);
        a9_toggle.SetActive(isActive);
        a10_toggle.SetActive(isActive);
    }

    public void ToggleA1(bool value)
    {
        a1.SetActive(value);
    }
    public void ToggleA2(bool value)
    {
        a2.SetActive(value);
    }
    public void ToggleA3(bool value)
    {
        a3.SetActive(value);
    }
    public void ToggleA4(bool value)
    {
        a4.SetActive(value);
    }
    public void ToggleA5(bool value)
    {
        a5.SetActive(value);
    }
    public void ToggleA6(bool value)
    {
        a6.SetActive(value);
    }
    public void ToggleA7(bool value)
    {
        a7.SetActive(value);
    }
    public void ToggleA8(bool value)
    {
        a8.SetActive(value);
    }
    public void ToggleA9(bool value)
    {
        a9.SetActive(value);
    }
    public void ToggleA10(bool value)
    {
        a10.SetActive(value);
    }
}
