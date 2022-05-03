using UnityEngine;

public class SpriteContainer : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites;

    public static SpriteContainer inst;

    public Sprite GetSprite(Global.TypeOfItem type)
    {
        if (type == Global.TypeOfItem.Trash) return sprites[0];
        return sprites[1];
    }

    private void Awake()
    {
        inst = this;
    }
}
