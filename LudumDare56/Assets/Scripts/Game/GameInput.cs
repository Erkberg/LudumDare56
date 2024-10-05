using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    private Controls controls;

    private void Awake()
    {
        controls = new Controls();
        controls.Enable();
    }

    public bool GetLeftButtonDown()
    {
        return controls.Player.MoveLeft.WasPressedThisFrame();
    }

    public bool GetRightButtonDown()
    {
        return controls.Player.MoveRight.WasPressedThisFrame();
    }

    public Vector2 GetLook()
    {
        return controls.Player.Look.ReadValue<Vector2>();
    }

    public bool GetCheatButtonDown()
    {
        return controls.Player.Cheat.WasPressedThisFrame();
    }

    public bool GetCheatButtonUp()
    {
        return controls.Player.Cheat.WasReleasedThisFrame();
    }

    public bool GetMenuButtonDown()
    {
        return controls.Player.Menu.WasPressedThisFrame();
    }
}
