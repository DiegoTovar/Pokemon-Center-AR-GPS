using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    public List<Button> SelectionButtons = new List<Button>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (Button button in SelectionButtons)
        {
            button.interactable = PlayerPrefs.GetInt(button.name) == 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pick(string name)
    {
        PlayerPrefs.SetInt("Name", 0);
        PlayerPrefs.Save();
        foreach (Button button in SelectionButtons)
        {
            if (button.name == name)
            {
                button.interactable = true;
            }
        }
    }
    public void Leave(string name)
    {
        PlayerPrefs.SetInt("Name",1);
        PlayerPrefs.Save();
        foreach (Button button in SelectionButtons)
        {
            if (button.name == name)
            {
                button.interactable = false;
            }
        }
    }
}
