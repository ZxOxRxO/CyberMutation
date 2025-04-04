using UnityEngine;

public class ObjectHighlighter : MonoBehaviour
{
    private Renderer objectRenderer;
    private Color originalColor;
    public Color highlightColor = Color.yellow;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalColor = objectRenderer.material.color;
    }

    void OnMouseEnter()
    {
        objectRenderer.material.color = highlightColor;
    }

    void OnMouseExit()
    {
        objectRenderer.material.color = originalColor;
    }
}

