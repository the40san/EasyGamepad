using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace EasyGamepad {
public interface IKeyCodeConverter {
	KeyCode VirtualButtonToKeyCode(GamePad.Button virtualButton);
	string VirtualStickToAxisName(GamePad.Stick virtualStick);
}

}