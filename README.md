# EasyGamepad
A simple Gamepad utility for Unity 

# Spec
Currently you can use Dualshock4 and Keyboard as PC.


# How to Use

To get button/stick state, write your code like this.

```csharp
// To get button down/up state
Gamepad.GetButtonState(GamePad.Button.A);

// To get button up state (1 frame)
Gamepad.GetButtonUp(GamePad.Button.A);

// To get button down state (1 frame)
Gamepad.GetButtonDown(GamePad.Button.A);

// To get Axis State
Gamepad.GetAxis(GamePad.Stick.LH);

// To check player is using controller or keyboard(property)
EasyGamepad.Switcher.IsUsingController

// To define controller/keyboard switch timing, call this.
EasyGamepad.Switcher.UpdateStatus();

```

All button list and stick enums are below

```
public enum Button { 
		A, B, X, Y, 
		L1, L2, L3, R1, R2, R3 
}

public enum Stick { LH, LV, RH, RV }
```
