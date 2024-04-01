using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public GameObject spaceship;
    public float moveSpeed = 25f; // Adjust speed as needed
    public float zoomSpeed = 0.5f; // Adjust zoom speed

    public void MoveLeft()
    {
        // Get the left direction in world space coordinates
        Vector3 leftDirection = -Vector3.right;

        // Move the spaceship in the left direction
        spaceship.transform.Translate(leftDirection * moveSpeed, Space.World);
    }
    public void MoveRight()
    {
        // Get the right direction in world space coordinates
        Vector3 rightDirection = Vector3.right;

        // Move the spaceship in the right direction
        spaceship.transform.Translate(rightDirection * moveSpeed, Space.World);
    }
    // Move the spaceship up
    public void MoveUp()
    {
        // Get the up direction in world space coordinates
        Vector3 upDirection = Vector3.up;

        // Move the spaceship up
        spaceship.transform.Translate(upDirection * moveSpeed, Space.World);
    }

    // Move the spaceship down
    public void MoveDown()
    {
        // Get the down direction in world space coordinates
        Vector3 downDirection = -Vector3.up;

        // Move the spaceship down
        spaceship.transform.Translate(downDirection * moveSpeed, Space.World);
    }

    // Zoom in
    public void ZoomIn()
    {
        // Scale the spaceship to simulate zooming in
        spaceship.transform.localScale += Vector3.one * zoomSpeed;
    }

    // Zoom out
    public void ZoomOut()
    {
        // Scale the spaceship to simulate zooming out
        spaceship.transform.localScale -= Vector3.one * zoomSpeed;
    }
}


