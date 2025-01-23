using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Handles the behavior of changing the color of a UI element over time.
/// </summary>
public class ColorLerpBehaviour : MonoBehaviour
{
    /// <summary>
    /// The starting color.
    /// </summary>
    public Color Start = Color.white;

    /// <summary>
    /// The ending color.
    /// </summary>
    public Color End = Color.white;

    /// <summary>
    /// The duration over which the color change occurs.
    /// </summary>
    public float Duration;

    /// <summary>
    /// The time elapsed.
    /// </summary>
    float _timeElapsed;

    /// <summary>
    /// Updates the color of the UI element each frame.
    /// </summary>
    void Update()
    {
        gameObject.GetComponent<Image>().color = Color.Lerp(Start, End, _timeElapsed / Duration);

        _timeElapsed += Time.deltaTime;
        if (_time > Duration)
        {
            _timeElapsed = Duration;
        }
    }
}
