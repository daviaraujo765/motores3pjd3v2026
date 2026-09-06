using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

public class ShareKeyboardP2 : MonoBehaviour
{
    private void Start()
    {
        PlayerInput playerInput = GetComponent<PlayerInput>();

        if (playerInput == null || Keyboard.current == null)
            return;

        playerInput.user.UnpairDevices();

        InputUser.PerformPairingWithDevice(
            Keyboard.current,
            playerInput.user
        );

        playerInput.SwitchCurrentControlScheme(
            "TecladoMouseSingleP2",
            Keyboard.current
        );

        // Faz o P2 usar somente as bindings do esquema P2
        playerInput.actions.bindingMask =
            InputBinding.MaskByGroup("TecladoMouseSingleP2");

        playerInput.ActivateInput();
    }
}