using UnityEngine;
using UnityEngine.UI;

public class Scrollbar_scripts : MonoBehaviour
{
    public Dropdown dropdown;
    public GameObject[] scrollbars;

    void Start()
    {
        UpdateScrollbars(dropdown.value);

        dropdown.onValueChanged.AddListener(UpdateScrollbars);
    }

    public void UpdateScrollbars(int index)
    {
        for (int i = 0; i < scrollbars.Length; i++)
        {
            scrollbars[i].SetActive(i == index); 
        }
    }
}
