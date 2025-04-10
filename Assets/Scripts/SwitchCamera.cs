using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchCamera : MonoBehaviour
{
    [SerializeField] private GameObject firstPersonCamera;
    [SerializeField] private GameObject thirdPersonCamera;
    public InputActionReference switchCameraAction;

    private bool isFirstPerson = false;

    // Active l'action de la caméra 
    private void OnEnable()
    {
        switchCameraAction.action.Enable();
        switchCameraAction.action.performed += OnSwitchCamera;
    }

    // Désactive l'action de la caméra
    private void OnDisable()
    {
        switchCameraAction.action.performed -= OnSwitchCamera;
        switchCameraAction.action.Disable();
    }

    // Switch the camera when the corresponding input action button is pressed
    private void OnSwitchCamera(InputAction.CallbackContext context)
    {
        if (isFirstPerson)
        {
            if (firstPersonCamera != null)
            {
                firstPersonCamera.SetActive(false);
            }
            if (thirdPersonCamera != null)
            {
                thirdPersonCamera.SetActive(true);
            }
        }
        else
        {
            if (thirdPersonCamera != null)
            {
                thirdPersonCamera.SetActive(false);
            }
            if (firstPersonCamera != null)
            {
                firstPersonCamera.SetActive(true);
            }
        }
        isFirstPerson = !isFirstPerson;
    }
}
