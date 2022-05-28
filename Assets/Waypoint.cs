using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Waypoint : MonoBehaviour
{
    public bool IsLeftSide;

    public Camera MyCam;
    // Indicator icon
    public Image img;
    // The target (location, enemy, etc..)
    public Transform target;

    private void Update()
    {
        if (target == null)
        {
            return;
        }
        // Giving limits to the icon so it sticks on the screen
        // Below calculations witht the assumption that the icon anchor point is in the middle
        // Minimum X position: half of the icon width
        float minX = (Screen.width / 2) + (img.GetPixelAdjustedRect().width / 6);
        if (IsLeftSide)
        {
            minX = (img.GetPixelAdjustedRect().width / 6);
        }

        // Maximum X position: screen width - half of the icon width
        float maxX = Screen.width - (img.GetPixelAdjustedRect().width / 6);
        if (IsLeftSide)
        {
            maxX = (Screen.width / 2) - (img.GetPixelAdjustedRect().width / 6);
        }

        // Minimum Y position: half of the height
        float minY = (img.GetPixelAdjustedRect().height / 6);
        // Maximum Y position: screen height - half of the icon height
        float maxY = Screen.height - minY;

        // Temporary variable to store the converted position from 3D world point to 2D screen point
        Vector2 pos = MyCam.WorldToScreenPoint(target.position + (target.up * 1.5f));

        // Check if the target is behind us, to only show the icon once the target is in front
        if (Vector3.Dot((target.position - transform.position), transform.forward) < 0)
        {
            // Check if the target is on the left side of the screen
            if (pos.x < (IsLeftSide ? Screen.width / 4 : (Screen.width / 2) + (Screen.width / 4)))
            {
                // Place it on the left side
                pos.x = minX;
            }
            else
            {

                // Place it on the right (Since it's behind the player, it's the opposite)
                pos.x = maxX;
            }
        }

        // Limit the X and Y positions
        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        // Update the marker's position
        img.transform.position = pos;
    }
}