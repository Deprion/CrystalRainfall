using UnityEngine;
using UnityEngine.UI;

public class ClickObject : MonoBehaviour
{
    private Item item;
    private Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
    }
    private void OnMouseDown()
    {
        GameManager.inst.ObjectClicked(item);

        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Destroy") Destroy(gameObject);
    }
    public void ItemSet(Item _item)
    {
        item = _item;
        image.sprite = SpriteContainer.inst.GetSprite(item.TypeOfItem);
    }
}
