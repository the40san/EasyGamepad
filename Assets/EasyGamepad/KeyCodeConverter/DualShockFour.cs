using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EasyGamepad
{
namespace KeyCodeConverter
{

public class DualShock : IKeyCodeConverter {
	public class InvalidVirtualButton : System.Exception 
	{
	}
	public class InvalidVirtualStick : System.Exception 
	{
	}

	public KeyCode VirtualButtonToKeyCode(GamePad.Button virutalButton)
	{
		switch(virutalButton)
		{
			case GamePad.Button.A:
				return KeyCode.Joystick1Button1;
			case GamePad.Button.B:
				return KeyCode.Joystick1Button2;
			case GamePad.Button.X:
				return KeyCode.Joystick1Button0;
			case GamePad.Button.Y:
				return KeyCode.Joystick1Button3;
			case GamePad.Button.L1:
				return KeyCode.Joystick1Button4;
			case GamePad.Button.L2:
				return KeyCode.Joystick1Button6;
			case GamePad.Button.L3:
				return KeyCode.Joystick1Button10;
			case GamePad.Button.R1:
				return KeyCode.Joystick1Button5;
			case GamePad.Button.R2:
				return KeyCode.Joystick1Button7;
			case GamePad.Button.R3:
				return KeyCode.Joystick1Button11;
			default:
				throw new InvalidVirtualButton();
		}
	}

	public string VirtualStickToAxisName(GamePad.Stick virtualStick)
	{
		switch(virtualStick)
		{
			case GamePad.Stick.LH:
				return "Horizontal";
			case GamePad.Stick.LV:
				return "Vertical";
			case GamePad.Stick.RH:
				return "Horizontal2";
			case GamePad.Stick.RV:
				return "Vertical2";
			default:
				throw new InvalidVirtualStick();
		}
	}
}

}
}
