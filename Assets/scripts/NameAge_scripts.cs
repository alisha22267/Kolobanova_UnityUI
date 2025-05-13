using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;
using System;

public class NameAge_scripts : MonoBehaviour
{
    public InputField nameInputField;
    public InputField ageInputField;
    public Text nameValidationText;
    public Text ageValidationText;
    public Text resultText;
    public Button switchSceneButton;

    void Start()
    {
        nameInputField.onValueChanged.AddListener(NameCheck);
        ageInputField.onValueChanged.AddListener(AgeCheck);

        switchSceneButton.onClick.AddListener(SwitchScene);
        switchSceneButton.interactable = false;  //poga nelaus parslegties uz citu slaidu
    }

    void NameCheck(string input)
    {
        if (Regex.IsMatch(input, "^[a-zA-ZāčēģīķļņšūžĀČĒĢĪĶĻŅŠŪŽ]*$"))
        {
            nameValidationText.text = "";
        }
        else
        {
            nameValidationText.text = "Vārdā drīkst būt tikai burti";
        }
    }

    void AgeCheck(string input)
    {
        if (Regex.IsMatch(input, "^[0-9]*$"))
        {
            ageValidationText.text = "";
        }
        else
        {
            ageValidationText.text = "Vecums drīkst saturēt tikai ciparus";
        }
    }

    public void ShowResult()
    {
        string name = nameInputField.text;
        string ageInput = ageInputField.text;

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ageInput))
        {
            resultText.text = "Lūdzu aizpildi visus laukus!";
            switchSceneButton.interactable = false; 
            return;
        }

        if (!Regex.IsMatch(name, "^[a-zA-ZāčēģīķļņšūžĀČĒĢĪĶĻŅŠŪŽ]+$"))
        {
            resultText.text = "Vārds nav derīgs!";
            switchSceneButton.interactable = false; 
            return;
        }

        if (!Regex.IsMatch(ageInput, "^[0-9]{4}$"))
        {
            resultText.text = "Lūdzu ievadi derīgu dzimšanas gadu";
            switchSceneButton.interactable = false; 
            return;
        }

        int birthYear = int.Parse(ageInput);
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        if (age < 0 || age > 120)
        {
            resultText.text = "Dzimšanas gads nav loģisks";
            switchSceneButton.interactable = false;  
            return;
        }

        resultText.text = $"Tēlu sauc {name} un viņam ir {age} gadi.";

        switchSceneButton.interactable = true;  
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene("Body_Color", LoadSceneMode.Single);
    }
}
