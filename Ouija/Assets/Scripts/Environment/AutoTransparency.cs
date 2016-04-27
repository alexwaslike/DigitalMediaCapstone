using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(EdgeCollider2D))]
public class AutoTransparency : MonoBehaviour
{
    private SpriteRenderer[] _spriteRenderers;
    private Color _defaultColor;
    private Color _transparentColor;

    void Start()
    {
        _spriteRenderers = GetComponentsInChildren<SpriteRenderer>();
        _defaultColor = _spriteRenderers[0].color;

        _transparentColor = new Color(_spriteRenderers[0].color.r, _spriteRenderers[0].color.g, _spriteRenderers[0].color.b, 0.3f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other);
        if (other.gameObject.tag.Equals("Player"))
        {
            foreach (SpriteRenderer renderer in _spriteRenderers)
                renderer.color = _transparentColor;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            foreach (SpriteRenderer renderer in _spriteRenderers)
                renderer.color = _defaultColor;
        }
    }

}
