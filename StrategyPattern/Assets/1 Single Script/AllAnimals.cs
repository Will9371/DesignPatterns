using UnityEngine;

public class AllAnimals : MonoBehaviour
{
    public enum AnimalType { dog, cat }
    public AnimalType myAnimal;

    public void OnClick()
    {
        switch(myAnimal)
        {
            case AnimalType.dog: DogSpeak(); break;
            case AnimalType.cat: CatSpeak(); break;
        }
    }

    void DogSpeak()
    {
        Debug.Log("Arf!");
    }

    void CatSpeak()
    {
        Debug.Log("Meow!");
    }
}
