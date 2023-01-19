using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour
{
    public GameObject switchUIBox;
    [SerializeField] bool uIOn = false;
    [SerializeField] Button firstButton;
    [SerializeField] Button secondButton;
    [SerializeField] Button thirdButton;
    [SerializeField] Button fourthButton;
    [SerializeField] Sprite currentSprite;
    [SerializeField] Sprite firstSprite;
    [SerializeField] Sprite secondSprite;
    [SerializeField] Sprite thirdSprite;
    [SerializeField] Sprite fourthSprite;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnSwitch(InputValue value)
    {
        Debug.Log("working");
        if (uIOn == false && value.isPressed)
        {
            switchUIBox.SetActive(true);
            uIOn = true;
            Debug.Log("Pressed Z");
        }
    }
}
