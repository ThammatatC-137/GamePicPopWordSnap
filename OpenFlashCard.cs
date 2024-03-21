using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFlashCard : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuObject;
    [SerializeField] private GameObject animalObject;
    [SerializeField] private GameObject animalFlashCard;
    [SerializeField] private GameObject bodyPartObject;
    [SerializeField] private GameObject bodyPartFlashCard;
    [SerializeField] private GameObject fruitObject;
    [SerializeField] private GameObject fruitFlashCard;
    [SerializeField] private GameObject categoryObject;

    public static Boolean loadBodyPart = false;
    public static Boolean loadAnimal = false;
    public static Boolean loadFruit = false;
    public static Boolean loadCategory = false;

    void Start()
    {
        if (loadAnimal == true)
        {
            animalObject.SetActive(true);
            animalFlashCard.SetActive(true);
            mainMenuObject.SetActive(false);
        } else if (loadBodyPart == true)
        { 
            bodyPartObject.SetActive(true);
            bodyPartFlashCard.SetActive(true);
            mainMenuObject.SetActive(false);
        } else if (loadFruit == true) 
        {
            fruitObject.SetActive(true);
            fruitFlashCard.SetActive(true);
            mainMenuObject.SetActive(false);
        } else if (loadCategory == true)
        {
            categoryObject.SetActive(true);
            mainMenuObject.SetActive(false);
        }
    }
}
