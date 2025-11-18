using System;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomItems : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Press Space to print one random item.");
        Debug.Log("Press Right Shift to print all items.");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))PrintRandomItem();
        if(Input.GetKeyDown(KeyCode.RightShift))PrintAllItems();
    }

    [SerializeField] private string[] randomItems = new string[10];

    private void PrintRandomItem()
    {
        var random = randomItems[Random.Range(0, randomItems.Length)];
        Debug.Log(random);
    }

    private void PrintAllItems()
    {
        for (int i = 0; i < randomItems.Length; i++)
        {
            Debug.Log(randomItems[i]);
        }
    }
}