using NUnit.Framework.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Text _bottleText;
    [SerializeField] private Text _snakeText;
    [SerializeField] private Text _basketText;
    [SerializeField] private Text _peopleText;

    [SerializeField] private TakeItem _itemData;

    private void Start()
    {
        UpdateAllCounters();
    }

    public void AddBottle()
    {
        _itemData.BottleCount++;
        UpdateCounter(_itemData.BottleCount, _bottleText);
    }

    public void AddSnake()
    {
        _itemData.SnakeCount++;
        UpdateCounter(_itemData.SnakeCount, _snakeText);
    }

    public void AddBasket()
    {
        _itemData.BasketCount++;
        UpdateCounter(_itemData.BasketCount, _basketText);
    }

    public void AddPerson()
    {
        _itemData.PeopleCount++;
        UpdateCounter(_itemData.PeopleCount, _peopleText);
    }

    private void UpdateCounter(int count, Text textField)
    {
        textField.text = count.ToString();
    }

    private void UpdateAllCounters()
    {
        UpdateCounter(_itemData.BottleCount, _bottleText);
        UpdateCounter(_itemData.SnakeCount, _snakeText);
        UpdateCounter(_itemData.BasketCount, _basketText);
        UpdateCounter(_itemData.PeopleCount, _peopleText);
    }

}
