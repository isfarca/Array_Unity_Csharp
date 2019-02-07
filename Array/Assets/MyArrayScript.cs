using UnityEngine;
using System.Linq;

public class MyArrayScript : MonoBehaviour
{
    #region Declare variables

    // Value types
    int number = 10;
    int[] empty = new int[] { };
    int[] numbers = new int[5];
    int[] otherNumbers = new int[] { 1, 2, 3, 4, 5, 10, 20 };

    #endregion

    #region Main function "Start()"

    // Use this for initialization
    void Start ()
    {
        // Algorithm
        PrintNumber();

        PrintArrayLengths();

        PrintOtherNumbers();

        CalculateAverage();

    }

    #endregion

    #region Custom functions

    #region Functions for "Start()"

    void PrintNumber()
    {
        Debug.LogFormat("number = {0}", number);
    }

    void PrintArrayLengths()
    {
        Debug.LogFormat("Length of empty = {0}", empty.Length);
        Debug.LogFormat("Length of numbers = {0}", numbers.Length);
        Debug.LogFormat("Length of numbers = {0}", otherNumbers.Length);
    }

    void PrintOtherNumbers()
    {
        for (int i = 0; i < otherNumbers.Length; i++)
            Debug.Log(otherNumbers[i]); // Access element by index
    }

    void CalculateAverage()
    {
        // Declare variables
        int randomIndex;
        int numberOfIndex = 100;
        int[] allNumbers = new int[numberOfIndex];

        for (int i = 0; i < numberOfIndex; i++)
        {
            randomIndex = Random.Range(0, otherNumbers.Length);
            Debug.LogFormat("random index = {0}, element value = {0}", randomIndex, otherNumbers[randomIndex]);

            allNumbers[i] = otherNumbers[randomIndex];
        }

        Debug.LogFormat("Average from all numbers = {0}", allNumbers.Average());
    }

    #endregion

    #endregion

    #region Return values

    float Average(float sum, int amount)
    {
        return sum / amount;
    }

    #endregion
}