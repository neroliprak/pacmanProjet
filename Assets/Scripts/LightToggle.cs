using UnityEngine;
using UnityEngine.InputSystem;

public class LightToggle : MonoBehaviour
{
    public Light sceneLight;
    public Renderer lampRenderer;
    public Material blueMaterial;
    public Material greenMaterial;
    public Material whiteMaterial;
    public Material transparentMaterial;

    // Reference to input action (L)
    public InputActionReference toggleLightAction;
    private int lightState = 0;

    // Current light colour used by player
    public static Color currentLightStateColor;

    // Enables the input action
    void OnEnable()
    {
        toggleLightAction.action.Enable();
        toggleLightAction.action.performed += OnToggleLight;
    }

    // Disables the input action
    void OnDisable()
    {
        toggleLightAction.action.performed -= OnToggleLight;
        toggleLightAction.action.Disable();
    }

    // Changes the state of the light each time the user presses the action input.
    // 0 - Light off
    // 1 - Blue light
    // 2 - Green light 
    // 3 - White light
    private void OnToggleLight(InputAction.CallbackContext context)
    {
        lightState = (lightState + 1) % 4;

        switch (lightState)
        {
            case 0:
                sceneLight.enabled = false;
                lampRenderer.material = transparentMaterial;
                currentLightStateColor = Color.clear;
                break;
            case 1:
                sceneLight.enabled = true;
                sceneLight.color = Color.blue;
                lampRenderer.material = blueMaterial;
                currentLightStateColor = Color.blue;
                break;
            case 2:
                sceneLight.enabled = true;
                sceneLight.color = Color.green;
                lampRenderer.material = greenMaterial;
                currentLightStateColor = Color.green;
                break;
            case 3:
                sceneLight.enabled = true;
                sceneLight.color = Color.white;
                lampRenderer.material = whiteMaterial;
                currentLightStateColor = Color.white;
                break;
        }

        UpdateAllWalls();
    }

    // Updates the wall trigger based on the player's currently active light color and the wall in front of them.
    private void UpdateAllWalls()
    {
        WallCollisionLight[] walls = FindObjectsOfType<WallCollisionLight>();

        foreach (WallCollisionLight wall in walls)
        {
            if (wall.wallColor == WallCollisionLight.WallColor.Blue && currentLightStateColor == Color.blue ||
                wall.wallColor == WallCollisionLight.WallColor.Green && currentLightStateColor == Color.green ||
                wall.wallColor == WallCollisionLight.WallColor.White && currentLightStateColor == Color.white)
            {
                wall.SetWallTrigger(true);
            }
            else
            {
                wall.SetWallTrigger(false);
            }
        }
    }
}
