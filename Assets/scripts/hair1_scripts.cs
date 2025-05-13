using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hair1_scripts : MonoBehaviour
{
    public GameObject black;
    public GameObject pink;
    public GameObject blue;
    public GameObject green;
    public GameObject purple;
    public GameObject brown;
    public GameObject red;

    public GameObject black_button;
    public GameObject pink_button;
    public GameObject blue_button;
    public GameObject green_button;
    public GameObject purple_button;
    public GameObject brown_button;
    public GameObject red_button;

    public GameObject mainButton;
    public GameObject showColorButton;

    public bool panelVisible = false;

    void Start()
    {
        mainButton.SetActive(true);
        showColorButton.SetActive(false);

        black_button.SetActive(false);
        pink_button.SetActive(false);
        blue_button.SetActive(false);
        green_button.SetActive(false);
        purple_button.SetActive(false);
        brown_button.SetActive(false);
        red_button.SetActive(false);

        black.SetActive(false);
        pink.SetActive(false);
        blue.SetActive(false);
        green.SetActive(false);
        purple.SetActive(false);
        brown.SetActive(false);
        red.SetActive(false);
    }

    public void OnMainButtonPressed()
    {
        panelVisible = !panelVisible;

        if (panelVisible)
        {
            showColorButton.SetActive(true);
        }
        else
        {
            showColorButton.SetActive(false);

            black_button.SetActive(false);
            pink_button.SetActive(false);
            blue_button.SetActive(false);
            green_button.SetActive(false);
            purple_button.SetActive(false);
            brown_button.SetActive(false);
            red_button.SetActive(false);
        }
    }

    public void OnShowColorButtonPressed()
    {
        showColorButton.SetActive(false);

        black_button.SetActive(true);
        pink_button.SetActive(true);
        blue_button.SetActive(true);
        green_button.SetActive(true);
        purple_button.SetActive(true);
        brown_button.SetActive(true);
        red_button.SetActive(true);
    }

    void HideAllExcept(GameObject active)
    {
        if (black != active) black.SetActive(false);
        if (pink != active) pink.SetActive(false);
        if (blue != active) blue.SetActive(false);
        if (green != active) green.SetActive(false);
        if (purple != active) purple.SetActive(false);
        if (brown != active) brown.SetActive(false);
        if (red != active) red.SetActive(false);
    }

    public void ShowBlack()
    {
        if (black.activeSelf)
            black.SetActive(false);
        else
        {
            HideAllExcept(black);
            black.SetActive(true);
        }
    }

    public void ShowPink()
    {
        if (pink.activeSelf)
            pink.SetActive(false);
        else
        {
            HideAllExcept(pink);
            pink.SetActive(true);
        }
    }

    public void ShowBlue()
    {
        if (blue.activeSelf)
            blue.SetActive(false);
        else
        {
            HideAllExcept(blue);
            blue.SetActive(true);
        }
    }

    public void ShowGreen()
    {
        if (green.activeSelf)
            green.SetActive(false);
        else
        {
            HideAllExcept(green);
            green.SetActive(true);
        }
    }

    public void ShowPurple()
    {
        if (purple.activeSelf)
            purple.SetActive(false);
        else
        {
            HideAllExcept(purple);
            purple.SetActive(true);
        }
    }

    public void ShowBrown()
    {
        if (brown.activeSelf)
            brown.SetActive(false);
        else
        {
            HideAllExcept(brown);
            brown.SetActive(true);
        }
    }

    public void ShowRed()
    {
        if (red.activeSelf)
            red.SetActive(false);
        else
        {
            HideAllExcept(red);
            red.SetActive(true);
        }
    }
}
