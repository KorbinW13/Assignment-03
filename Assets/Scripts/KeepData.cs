using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{
    public static string PlayerName;
    public static float RotatorSpeed = 10f;
    public static float PinSpeed = 20f;
    public static int ColorNumber = 0;

    public InputField PlayerNameInput;
    public Slider pinSlider;
    public Slider rotatorSlider;
    public Dropdown ColorDropdown;

    public SpriteRenderer rotatorSprite;

    public Text showPlayerName;
    public Text PinText;
    public Text RotatorText;
    public Text ColorText;

    void Start()
    {
        rotatorSlider.value = RotatorSpeed;
        pinSlider.value = PinSpeed;
        PlayerNameInput.text = PlayerName;

        ColorDropdown.value = ColorNumber;
        ColorText.text = "Rotator Color: " + ColorDropdown.options[ColorDropdown.value].text;
        SetColor(ColorDropdown);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(PlayerName + " playing at " + RotatorSpeed + " Rotation Speed and " + PinSpeed + " Pin Speed");
    }

    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
        Debug.Log(PlayerName);
        showPlayerName.text = PlayerName;
    }

    public void RotatorSlider()
    {
        RotatorText.text = "Rotator Speed: " + rotatorSlider.value;
        Debug.Log(rotatorSlider.value);
        RotatorSpeed = rotatorSlider.value;
    }
    public void PinSlider()
    {
        PinText.text = "Pin Speed: " + pinSlider.value;
        Debug.Log(pinSlider.value);
        PinSpeed = pinSlider.value;
    }

    public void SetColor(Dropdown sender)
    {
        switch (sender.value)
        {
            case 0:
                ColorText.text = "Rotator Color: " + sender.options[0].text;
                rotatorSprite.color = Color.black;
                break;
            case 1:
                ColorText.text = "Rotator Color: " + sender.options[1].text;
                rotatorSprite.color = Color.blue;
                break;
            case 2:
                ColorText.text = "Rotator Color: " + sender.options[2].text;
                rotatorSprite.color = Color.red;
                break;
        }
        ColorNumber = sender.value;
    }

    public void UpdateColor(Dropdown sender)
    {
        ColorNumber = sender.value;
        SetColor(sender);
        Debug.Log("Color: " + sender.options[sender.value].text);
        sender.value = ColorNumber;
    }
}
