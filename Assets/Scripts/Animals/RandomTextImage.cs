using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class TextImageItem
{
    public string text;
    public Sprite image;
}

public class RandomTextImage : MonoBehaviour
{
    public GameObject RandomizeImagePanel;
    public GameObject RandomizeTextPanel;
    public GameObject RandomizeButton;
    public TextMeshProUGUI textMeshPro;
    public Image uiImage;

    public List<TextImageItem> items;

    public void ApplyRandomItem()
    {

        if (items == null || items.Count == 0) return;

        int randomIndex = Random.Range(0, items.Count);
        TextImageItem chosenItem = items[randomIndex];
        
        RandomizeButton.SetActive(false);
        RandomizeImagePanel.SetActive(true);
        RandomizeTextPanel.SetActive(true);

        if (textMeshPro != null)
            textMeshPro.text = chosenItem.text;

        if (uiImage != null)
            uiImage.sprite = chosenItem.image;

        
    }
}
