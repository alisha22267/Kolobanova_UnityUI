using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageShirts_scripts : MonoBehaviour
{
    public GameObject shirt1;
    public GameObject shirt2;
    public GameObject shirt3;
    public GameObject shirt4;
    public GameObject shirt5;
    public GameObject shirt6;
    public GameObject shirt7;
    public GameObject shirt8;
    public GameObject shirt9;
    public GameObject shirt10;

    public GameObject shirt1_toggle;
    public GameObject shirt2_toggle;
    public GameObject shirt3_toggle;
    public GameObject shirt4_toggle;
    public GameObject shirt5_toggle;
    public GameObject shirt6_toggle;
    public GameObject shirt7_toggle;
    public GameObject shirt8_toggle;
    public GameObject shirt9_toggle;
    public GameObject shirt10_toggle;


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
        shirt1_toggle.SetActive(isActive);
        shirt2_toggle.SetActive(isActive);
        shirt3_toggle.SetActive(isActive);
        shirt4_toggle.SetActive(isActive);
        shirt5_toggle.SetActive(isActive);
        shirt6_toggle.SetActive(isActive);
        shirt7_toggle.SetActive(isActive);
        shirt8_toggle.SetActive(isActive);
        shirt9_toggle.SetActive(isActive);
        shirt10_toggle.SetActive(isActive);

    }

    public void ToggleShirt1(bool value)
    {
        shirt1.SetActive(value);
    }
    public void ToggleShirt2(bool value)
    {
        shirt2.SetActive(value);
    }
    public void ToggleShirt3(bool value)
    {
        shirt3.SetActive(value);
    }
    public void ToggleShirt4(bool value)
    {
        shirt4.SetActive(value);
    }
    public void ToggleShirt5(bool value)
    {
        shirt5.SetActive(value);
    }
    public void ToggleShirt6(bool value)
    {
        shirt6.SetActive(value);
    }
    public void ToggleShirt7(bool value)
    {
        shirt7.SetActive(value);
    }
    public void ToggleShirt8(bool value)
    {
        shirt8.SetActive(value);
    }
    public void ToggleShirt9(bool value)
    {
        shirt9.SetActive(value);
    }
    public void ToggleShirt10(bool value)
    {
        shirt10.SetActive(value);
    }
}
