using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace EasyGamepad {

public static class Switcher {
	private static bool _usingController = true;

	public static bool UsingController {
		get {
			return _usingController;
		}
		set {
			_usingController = value;
		}
	}

	public static void UpdateStatus()
	{
		if (UsingController)
		{
			IKeyCodeConverter converter = new KeyCodeConverter.PCKeyboard();
			if (CheckButtonPressed(converter))
			{
				UsingController = false;
			}
		}
		else
		{
			// switch status to PC Mode if any key is pressed
			IKeyCodeConverter converter = new KeyCodeConverter.DualShock();
			if (CheckButtonPressed(converter))
			{
				UsingController = true;
			}
		}
	}

	private static bool CheckButtonPressed(IKeyCodeConverter converter)
	{
		return (
			Input.GetKey(converter.VirtualButtonToKeyCode(GamePad.Button.A)) ||
			Input.GetKey(converter.VirtualButtonToKeyCode(GamePad.Button.B)) ||
			Input.GetKey(converter.VirtualButtonToKeyCode(GamePad.Button.X)) ||
			Input.GetKey(converter.VirtualButtonToKeyCode(GamePad.Button.Y)) ||
			Input.GetKey(converter.VirtualButtonToKeyCode(GamePad.Button.L1)) ||
			Input.GetKey(converter.VirtualButtonToKeyCode(GamePad.Button.L2)) ||
			Input.GetKey(converter.VirtualButtonToKeyCode(GamePad.Button.L3)) ||
			Input.GetKey(converter.VirtualButtonToKeyCode(GamePad.Button.R1)) ||
			Input.GetKey(converter.VirtualButtonToKeyCode(GamePad.Button.R2)) ||
			Input.GetKey(converter.VirtualButtonToKeyCode(GamePad.Button.R3))
		);
	}
}
}