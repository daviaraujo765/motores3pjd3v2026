using UnityEngine;
using UnityEngine.InputSystem;

public class ShareKeyboardP2 : MonoBehaviour
{
    private void Start()
    {
        PlayerInput playerInput = GetComponent<PlayerInput>();

        if (playerInput != null && Keyboard.current != null)
        {
            playerInput.SwitchCurrentControlScheme(
                "TecladoMouseSingleP2",
                Keyboard.current
            );
        }
    }
}