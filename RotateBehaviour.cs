using UnityEngine;

/// <summary>
/// Handles the rotation of a game object at a specified speed.
/// </summary>
public class RotateBehaviour : MonoBehaviour
{
    /// <summary>
    /// The speed of rotation.
    /// </summary>
    public float Speed;

    /// <summary>
    /// Called once per frame to update the rotation of the game object.
    /// </summary>
    void Update()
    {
        gameObject.transform.Rotate(0, 0, Speed * Time.deltaTime);
    }
}
