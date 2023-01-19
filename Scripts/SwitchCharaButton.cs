using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchCharaButton : MonoBehaviour
{
    [SerializeField] GameObject currentSprite;
    [SerializeField] Sprite kachinaSprite;
    [SerializeField] Sprite rosaSprite;
    [SerializeField] Sprite lolaSprite;
    [SerializeField] Sprite margotSprite;

    SwitchChara switchChara;

    void Start()
    {
        switchChara = FindObjectOfType<SwitchChara>();
    }
    public void SwitchToKachina() {

        currentSprite.GetComponent<SpriteRenderer>().sprite = kachinaSprite;
        switchChara.SwitchOff();
    }
    public void SwitchToRosa() {

        currentSprite.GetComponent<SpriteRenderer>().sprite = rosaSprite;
        switchChara.SwitchOff();
    }
    public void SwitchToMargot() {

        currentSprite.GetComponent<SpriteRenderer>().sprite = margotSprite;
        switchChara.SwitchOff();
    }
    public void SwitchToLola() {

        currentSprite.GetComponent<SpriteRenderer>().sprite = lolaSprite;
        switchChara.SwitchOff();
    }

    public void DebugHere()
    {
        Debug.Log("Button working");
    }
}
