using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestDialogueBuilder : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI tmpro; // Reference to the TextMeshProUGUI object

    private void Start()
    {
        Invoke("BuildText", -1); // Call the BuildText function after 0 seconds
    }

    void BuildText()
    {
        StopAllCoroutines(); // Stop all running coroutines
        string targetText = "This is a random test of building some dialogue on the screen.\nTell me how it looks?";
        StartCoroutine(BuildingText(targetText)); // Start the BuildingText coroutine
    }

    IEnumerator BuildingText(string targetText)
    {
        tmpro.text = ""; // Clear the text
        foreach (char c in targetText)
        {
            tmpro.text += c; // Add each character to the text
            yield return new WaitForSeconds(0.01f); // Wait for 0.01 seconds
        }
    }
}
