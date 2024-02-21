using UnityEngine;

/// <summary>
/// Cursor script. Place as a direct child of the canvas
/// </summary>
public class Cursor : SingletonMonoBehavior<Cursor>
{
    private RectTransform rectTransform;
    private Canvas canvas;
    private Rect pixelRect;

    private void OnEnable()
    {
        canvas = transform.parent.GetComponent<Canvas>();
        rectTransform = GetComponent<RectTransform>();
        pixelRect = canvas.pixelRect;
    }

    /// <summary>
    /// Get the curor's current normalised position on the canvas
    /// </summary>
    /// <returns>Vector2 normalised position on canvas</returns>
    public Vector2 GetNormalisedPosition()
    {
        Vector2 anchoredPosition = rectTransform.anchoredPosition;
        Vector2 normalizedPosition = new(
            anchoredPosition.x / pixelRect.width,
            anchoredPosition.y / pixelRect.height
        );
        return normalizedPosition;
    }
    
    /// <summary>
    /// Set normalized cursor value between (-1.0f,-1.0f) to (1.0f,1.0f) where (0.0f,0.0f) is the center
    /// </summary>
    /// <param name="xNorm">float between -1.0f to 1.0f (left to right)</param>
    /// <param name="yNorm">float between -1.0f to 1.0f (bottom to top)</param>
    public void SetNormalisedPosition(float xNorm, float yNorm)
    {
        Vector2 newPosition = new(xNorm * pixelRect.width, yNorm * pixelRect.height);
        rectTransform.anchoredPosition = newPosition;
    }
}
