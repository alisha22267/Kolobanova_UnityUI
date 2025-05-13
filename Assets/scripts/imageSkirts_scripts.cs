using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageSkirts_scripts : MonoBehaviour
{
    public GameObject skirt1;
    public GameObject skirt2;
    public GameObject skirt3;
    public GameObject skirt4;
    public GameObject skirt5;
    public GameObject skirt6;
    public GameObject skirt7;
    public GameObject skirt8;
    public GameObject skirt9;
    public GameObject skirt10;

    public GameObject skirt1_toggle;
    public GameObject skirt2_toggle;
    public GameObject skirt3_toggle;
    public GameObject skirt4_toggle;
    public GameObject skirt5_toggle;
    public GameObject skirt6_toggle;
    public GameObject skirt7_toggle;
    public GameObject skirt8_toggle;
    public GameObject skirt9_toggle;
    public GameObject skirt10_toggle;



    public bool togglesVisible = false;

    void Start()
    {
        SetTogglesActive(false); //sakuma paslepti
    }

    public void ToggleTogglesVisibility()
    {
        togglesVisible = !togglesVisible;
        SetTogglesActive(togglesVisible);
    }

    public void SetTogglesActive(bool isActive)
    {
        skirt1_toggle.SetActive(isActive);
        skirt2_toggle.SetActive(isActive);
        skirt3_toggle.SetActive(isActive);
        skirt4_toggle.SetActive(isActive);
        skirt5_toggle.SetActive(isActive);
        skirt6_toggle.SetActive(isActive);
        skirt7_toggle.SetActive(isActive);
        skirt8_toggle.SetActive(isActive);
        skirt9_toggle.SetActive(isActive);
        skirt10_toggle.SetActive(isActive);

    }

    public void ToggleSkirt1(bool value)
    {
        skirt1.SetActive(value);
    }
    public void ToggleSkirt2(bool value)
    {
        skirt2.SetActive(value);
    }
    public void ToggleSkirt3(bool value)
    {
        skirt3.SetActive(value);
    }
    public void ToggleSkirt4(bool value)
    {
        skirt4.SetActive(value);
    }
    public void ToggleSkirt5(bool value)
    {
        skirt5.SetActive(value);
    }
    public void ToggleSkirt6(bool value)
    {
        skirt6.SetActive(value);
    }
    public void ToggleSkirt7(bool value)
    {
        skirt7.SetActive(value);
    }
    public void ToggleSkirt8(bool value)
    {
        skirt8.SetActive(value);
    }
    public void ToggleSkirt9(bool value)
    {
        skirt9.SetActive(value);
    }
    public void ToggleSkirt10(bool value)
    {
        skirt10.SetActive(value);
    }

}
