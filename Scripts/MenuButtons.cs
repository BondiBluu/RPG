using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] Button iconButton;
    bool iconUp;
    [SerializeField] Button saveButton;
    [SerializeField] Button invenButton;
    [SerializeField] Button charaButton;

    // Start is called before the first frame update
    void Start()
    {
        IconOff();
    }

    public void IconOff()
    {
        iconUp = false;
        saveButton.gameObject.SetActive(false);
        invenButton.gameObject.SetActive(false);
        charaButton.gameObject.SetActive(false);
    }

    public void IconOn()
    {

        if(iconUp == false)
        {
            iconUp = true;
            saveButton.gameObject.SetActive(true);
            invenButton.gameObject.SetActive(true);
            charaButton.gameObject.SetActive(true);
        } 
        else if(iconUp == true)
        {
            IconOff();
        }
    }
}
