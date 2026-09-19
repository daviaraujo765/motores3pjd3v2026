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
            "TecladoEMouseSingleP2",
            Keyboard.current
        );

        playerInput.actions.bindingMask =
            InputBinding.MaskByGroup("TecladoEMouseSingleP2");

        playerInput.ActivateInput();
    }
}