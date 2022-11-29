using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_PlayerMovement : MonoBehaviour
{
    private string input_ActionButton;
    private string input_ClimbButton;
    private string input_UseButton;
    private string input_SprintButton;
    private string input_Horizontal;
    private string input_Vertical;
    private string input_ItemWheel;
    private string input_SneakButton;
    private string input_PauseButton;
    private string input_MapButton;
    private string input_Slot1;
    private string input_Slot2;
    private string input_Slot3;
    private string input_Slot4;
    private string input_Zoom;
    private string input_Focus;
    private void Awake()
    {
        input_ActionButton = "";
        input_ClimbButton = "";
        input_UseButton = "";
        input_SprintButton = "";
        input_Horizontal = "";
        input_Vertical = "";
        input_ItemWheel = "";
        input_SneakButton = "";
        input_PauseButton = "";
        input_MapButton = "";
        input_Slot1 = "";
        input_Slot2 = "";
        input_Slot3 = "";
        input_Slot4 = "";
        input_Zoom = "";
        input_Focus = "";
    }

    public string GetButton(int buttonNum)
    {
        var result = "";
        switch (buttonNum)
        {
            case 0:
                result = input_ActionButton;
                break;
            case 1:
                result = input_ClimbButton;
                break;
            case 2:
                result = input_UseButton;
                break;
            case 3:
                result = input_SprintButton;
                break;
            case 4:
                result = input_Horizontal;
                break;
            case 5:
                result = input_Vertical;
                break;
            case 6:
                result = input_ItemWheel;
                break;
            case 7:
                result = input_SneakButton;
                break;
            case 8:
                result = input_PauseButton;
                break;
            case 9:
                result = input_MapButton;
                break;
            case 10:
                result = input_Slot1;
                break;
            case 11:
                result = input_Slot2;
                break;
            case 12:
                result = input_Slot3;
                break;
            case 13:
                result = input_Slot4;
                break;
            case 14:
                result = input_Zoom;
                break;
            case 15:
                result = input_Focus;
                break;
            default:
                result = input_ActionButton;
                break;
        }
        return result;
    }
    public void SetButton(string buttonName, int buttonNumb)
    {
        switch (buttonNumb)
        {
            case 0:
                input_ActionButton = buttonName;
                break;
            case 1:
                input_ClimbButton = buttonName;
                break;
            case 2:
                input_UseButton = buttonName;
                break;
            case 3:
                input_SprintButton = buttonName;
                break;
            case 4:
                input_Horizontal = buttonName;
                break;
            case 5:
                input_Vertical = buttonName;
                break;
            case 6:
                input_ItemWheel = buttonName;
                break;
            case 7:
                input_SneakButton = buttonName;
                break;
            case 8:
                input_PauseButton = buttonName;
                break;
            case 9:
                input_MapButton = buttonName;
                break;
            case 10:
                input_Slot1 = buttonName;
                break;
            case 11:
                input_Slot2 = buttonName;
                break;
            case 12:
                input_Slot3 = buttonName;
                break;
            case 13:
                input_Slot4 = buttonName;
                break;
            case 14:
                input_Zoom = buttonName;
                break;
            case 15:
                input_Focus = buttonName;
                break;
            default:
                input_ActionButton = buttonName;
                break;
        }
    }

}
