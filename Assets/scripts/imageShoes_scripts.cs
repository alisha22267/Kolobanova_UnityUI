using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageShoes_scripts : MonoBehaviour
{
    public GameObject shoes1;
    public GameObject shoes2;
    public GameObject shoes3;
    public GameObject shoes4;
    public GameObject shoes5;
    public GameObject shoes6;

    public GameObject shoes1_toggle;
    public GameObject shoes2_toggle;
    public GameObject shoes3_toggle;
    public GameObject shoes4_toggle;
    public GameObject shoes5_toggle;
    public GameObject shoes6_toggle;


    public bool togglesVisible = false;

    void Start()
    {
        SetTogglesActive(false);
    }

    public void ToggleTogglesVisibility()
    {
        togglesVisible = !togglesVisible;
        SetTogglesActive(togglesVisible);
    }

    public void SetTogglesActive(bool isActive)
    {
        shoes1_toggle.SetActive(isActive);
        shoes2_toggle.SetActive(isActive);
        shoes3_toggle.SetActive(isActive);
        shoes4_toggle.SetActive(isActive);
        shoes5_toggle.SetActive(isActive);
        shoes6_toggle.SetActive(isActive);
    }

    public void ToggleShoes1(bool value)
    {
        shoes1.SetActive(value);
    }
    public void ToggleShoes2(bool value)
    {
        shoes2.SetActive(value);
    }
    public void ToggleShoes3(bool value)
    {
        shoes3.SetActive(value);
    }
    public void ToggleShoes4(bool value)
    {
        shoes4.SetActive(value);
    }
    public void ToggleShoes5(bool value)
    {
        shoes5.SetActive(value);
    }
    public void ToggleShoes6(bool value)
    {
        shoes6.SetActive(value);
    }
}
