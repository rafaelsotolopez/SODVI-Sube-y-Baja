
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameInputActions inputActions;
    private PlayerMovement playerMovement;

    private void Awake()
    {
        inputActions = new GameInputActions();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void OnEnable()
    {
        inputActions.Gameplay.Enable();
    }

    private void Update()
    {
        float verticalInput = inputActions.Gameplay.MoveVertical.ReadValue<float>();

        playerMovement.SetMovementInput(verticalInput);
    }

    private void OnDisable()
    {
        inputActions.Gameplay.Disable();
    }

    private void OnDestroy()
    {
        inputActions.Dispose();
    }
}
