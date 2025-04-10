using UnityEngine;

public class WallCollisionLight : MonoBehaviour
{
    public enum WallColor { Blue, Green, White }
    public WallColor wallColor;

    private Collider wallCollider;

    // Reference to the player's light colour, defined in LightToggle.cs
    public static Color currentLightStateColor;

    private void Start()
    {
        wallCollider = GetComponent<Collider>();
    }

    // Enable/disable wall trigger based on colour
    public void SetWallTrigger(bool isActive)
    {
        wallCollider.isTrigger = isActive;
    }

    // Checks whether the colour of the light matches the colour required by the wall
    private bool IsCorrectColor()
    {
        switch (wallColor)
        {
            case WallColor.Blue:
                return currentLightStateColor == Color.blue;
            case WallColor.Green:
                return currentLightStateColor == Color.green;
            case WallColor.White:
                return currentLightStateColor == Color.white;
            default:
                return false;
        }
    }
}
