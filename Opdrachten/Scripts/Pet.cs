using UnityEngine;

public class SimplePet : MonoBehaviour
{
    [Header("Pet Info")]
    public string petName = "Buddy";
    public string petType = "Dog";
    public int petAge = 1;

    public float petWeight = 25.7f;

    [Header("Pet Needs")]
    public int hunger = 50;
    public int happiness = 70;
    public int energy = 80;

    [Header("Pet Status")]
    public bool isSleeping = false;
    public bool isHungry = false;
    public string mood = "Happy";

    void Start()
    {
        Debug.Log("Meet your new pet: " + petName + " the " + petType);
        Debug.Log("Age: " + petAge + " years old");
        Debug.Log("Controls: F = Feed | P = Play | S = Sleep | I = Info");
        ShowPetInfo();
    }

    void Update()
    {
        if (hunger < 30)
        {
            isHungry = true;
            mood = "Hungry";
        }
        else if (energy < 20)
        {
            mood = "Tired";
        }
        else if (happiness > 80)
        {
            mood = "Very Happy";
        }
        else
        {
            mood = "Happy";
            isHungry = false;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (hunger < 100)
            {
                hunger += 25;
                happiness += 10;
                petWeight += 0.5f;
                Debug.Log("Fed " + petName + "! Hunger is now: " + hunger);

                if (hunger > 100) hunger = 100;
                if (happiness > 100) happiness = 100;
            }
            else
            {
                Debug.Log(petName + " is already full!");
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!isSleeping && energy > 10)
            {
                happiness += 20;
                energy -= 15;
                hunger -= 10;
                Debug.Log("Played with " + petName + "! Happiness: " + happiness);

                if (happiness > 100) happiness = 100;
                if (energy < 0) energy = 0;
                if (hunger < 0) hunger = 0;
            }
            else if (isSleeping)
            {
                Debug.Log(petName + " is sleeping!");
            }
            else
            {
                Debug.Log(petName + " is too tired to play!");
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            isSleeping = !isSleeping;

            if (isSleeping)
            {
                Debug.Log(petName + " is now sleeping...");
                energy += 30;
                if (energy > 100) energy = 100;
            }
            else
            {
                Debug.Log(petName + " woke up!");
            }
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            ShowPetInfo();
        }
    }

    void ShowPetInfo()
    {
        Debug.Log("=== PET STATUS ===");
        Debug.Log("Name: " + petName);
        Debug.Log("Type: " + petType);
        Debug.Log("Age: " + petAge + " years");
        Debug.Log("Weight: " + petWeight + "kg");
        Debug.Log("Mood: " + mood);
        Debug.Log("Hunger: " + hunger + "/100");
        Debug.Log("Happiness: " + happiness + "/100");
        Debug.Log("Energy: " + energy + "/100");
        Debug.Log("Sleeping: " + isSleeping);
        Debug.Log("==================");
    }
}

