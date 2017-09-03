using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EasyGamepad
{
namespace KeyCodeConverter
{

public class PCKeyboard : IKeyCodeConverter {

	public class InvalidVirtualButton : System.Exception
	{
	}

	public class InvalidVirtualStick : System.Exception
	{
	}

	public KeyCode VirtualButtonToKeyCode(GamePad.Button virtualButton)
	{
		switch(virtualButton)
		{
			case GamePad.Button.A:
				return KeyCode.H;
			case GamePad.Button.B:
				return KeyCode.J;
			case GamePad.Button.X:
				return KeyCode.K;
			case GamePad.Button.Y:
				return KeyCode.L;
			case GamePad.Button.L1:
				return KeyCode.T;
			case GamePad.Button.L2:
				return KeyCode.Y;
			case GamePad.Button.L3:
				return KeyCode.U;
			case GamePad.Button.R1:
				return KeyCode.I;
			case GamePad.Button.R2:
				return KeyCode.O;
			case GamePad.Button.R3:
				return KeyCode.P;
			default:
				throw new InvalidVirtualButton();
		}

	}

	public string VirtualStickToAxisName(GamePad.Stick virtualStick)
	{
		switch(virtualStick)
		{
			case GamePad.Stick.LH:
				return "Horizontal2";
			case GamePad.Stick.LV:
				return "Vertical2";
			case GamePad.Stick.RH:
				return "Horizontal";
			case GamePad.Stick.RV:
				return "Vertical";
			default:
				throw new InvalidVirtualStick();
		}
	}
}

}

}