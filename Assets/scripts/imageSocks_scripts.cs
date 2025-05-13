using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageSocks_scripts : MonoBehaviour
{
    public GameObject socks1;
    public GameObject socks2;
    public GameObject socks3;


    public GameObject socks1_toggle;
    public GameObject socks2_toggle;
    public GameObject socks3_toggle;

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
        socks1_toggle.SetActive(isActive);
        socks2_toggle.SetActive(isActive);
        socks3_toggle.SetActive(isActive);
    }

    public void ToggleSocks1(bool value)
    {
        socks1.SetActive(value);
    }
    public void ToggleSocks2(bool value)
    {
        socks2.SetActive(value);
    }
    public void ToggleSocks3(bool value)
    {
        socks3.SetActive(value);
    }
}
