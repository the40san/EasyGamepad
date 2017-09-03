using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyGamepad;
using UnityEngine.UI;

public class TestScript : MonoBehaviour {
	public Text text;
	public Text text2;
	
	void Update () 
	{
		text.text = "";
		text.text += enumToString(KeyCode.Joystick1Button0);
		text.text += enumToString(KeyCode.Joystick1Button1);
		text.text += enumToString(KeyCode.Joystick1Button2);
		text.text += enumToString(KeyCode.Joystick1Button3);
		text.text += enumToString(KeyCode.Joystick1Button4);
		text.text += enumToString(KeyCode.Joystick1Button5);
		text.text += enumToString(KeyCode.Joystick1Button6);
		text.text += enumToString(KeyCode.Joystick1Button7);
		text.text += enumToString(KeyCode.Joystick1Button8);
		text.text += enumToString(KeyCode.Joystick1Button9);
		text.text += enumToString(KeyCode.Joystick1Button10);
		text.text += enumToString(KeyCode.Joystick1Button11);
		text.text += enumToString(KeyCode.Joystick1Button12);
		text.text += enumToString(KeyCode.Joystick1Button13);
		text.text += enumToString(KeyCode.Joystick1Button14);
		text.text += enumToString(KeyCode.Joystick1Button15);
		text.text += enumToString(KeyCode.Joystick1Button16);
		text.text += enumToString(KeyCode.Joystick1Button17);
		text.text += enumToString(KeyCode.Joystick1Button18);
		text.text += enumToString(KeyCode.Joystick1Button18);
		text.text += "\n";

		text.text += axisToString("Horizontal");
		text.text += axisToString("Vertical");
		text.text += axisToString("Horizontal2");
		text.text += axisToString("Vertical2");

		text2.text = "";
		text2.text += virtualButtonToStatusString(GamePad.Button.A);
		text2.text += virtualButtonToStatusString(GamePad.Button.B);
		text2.text += virtualButtonToStatusString(GamePad.Button.X);
		text2.text += virtualButtonToStatusString(GamePad.Button.Y);
		text2.text += virtualButtonToStatusString(GamePad.Button.L1);
		text2.text += virtualButtonToStatusString(GamePad.Button.L2);
		text2.text += virtualButtonToStatusString(GamePad.Button.L3);
		text2.text += virtualButtonToStatusString(GamePad.Button.R1);
		text2.text += virtualButtonToStatusString(GamePad.Button.R2);
		text2.text += virtualButtonToStatusString(GamePad.Button.R3);
		text2.text += "\n";

		text2.text += virtualStickToStatusString(GamePad.Stick.LH);
		text2.text += virtualStickToStatusString(GamePad.Stick.LV);
		text2.text += virtualStickToStatusString(GamePad.Stick.RH);
		text2.text += virtualStickToStatusString(GamePad.Stick.RV);
	}

	private string virtualButtonToStatusString(GamePad.Button vButton)
	{
		return vButton.ToString() + ": " + GamePad.GetButtonState(vButton) + "\n";
	}

	private string virtualStickToStatusString(GamePad.Stick vStick)
	{
		return vStick.ToString() + ": " + GamePad.GetAxis(vStick) + "\n";
	}

	private string enumToString(KeyCode keycode)
	{
		return keycode.ToString() + ": " + Input.GetKey(keycode) + "\n";
	} 

	private string axisToString(string axis)
	{
		return axis + ": " + Input.GetAxis(axis) + "\n";
	}
}