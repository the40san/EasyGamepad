using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyGamepad;

namespace EasyGamepad {

public static class GamePad {
	public enum Button { 
		A, B, X, Y, 
		L1, L2, L3, R1, R2, R3 
	}

	public enum Stick { LH, LV, RH, RV };

	public static bool GetButtonDown(GamePad.Button virtualButton)
	{
		KeyCode keycode = GetKeyCodeConverter().VirtualButtonToKeyCode(virtualButton);
		return Input.GetKeyDown(keycode);
	}

	public static bool GetButtonUp(GamePad.Button virtualButton)
	{
		KeyCode keycode = GetKeyCodeConverter().VirtualButtonToKeyCode(virtualButton);
		return Input.GetKeyUp(keycode);
	}

	public static bool GetButtonState(GamePad.Button virtualButton)
	{
		KeyCode keycode = GetKeyCodeConverter().VirtualButtonToKeyCode(virtualButton);
		return Input.GetKey(keycode);
	}

	public static float GetAxis(GamePad.Stick virtualStick)
	{
		string axisName = GetKeyCodeConverter().VirtualStickToAxisName(virtualStick);
		return Input.GetAxis(axisName);
	}

	public static bool GetAnyButtonDown()
	{
		return Input.anyKey;
	}

	private static IKeyCodeConverter GetKeyCodeConverter()
	{
		if (Switcher.UsingController)
		{
			return new KeyCodeConverter.DualShock();
		}
		return new KeyCodeConverter.PCKeyboard();
	}
}
}