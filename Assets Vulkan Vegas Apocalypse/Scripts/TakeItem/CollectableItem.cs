using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    public enum ItemType { Bottle, Snake, Basket, People }

    [SerializeField] private ItemType _itemType;

    [SerializeField] private ItemCollector _itemCollector;

    private void OnMouseDown() => HandleCollection();

    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            RaycastHit2D hit = Physics2D.Raycast(
                Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position),
                Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                HandleCollection();
            }
        }
    }

    private void HandleCollection()
    {
        if (_itemCollector == null) return;

        switch (_itemType)
        {
            case ItemType.Bottle:
                _itemCollector.AddBottle();
                break;
            case ItemType.Snake:
                _itemCollector.AddSnake();
                break;
            case ItemType.Basket:
                _itemCollector.AddBasket();
                break;
            case ItemType.People:
                _itemCollector.AddPerson();
                break;
        }

        Destroy(gameObject);
    }
}
