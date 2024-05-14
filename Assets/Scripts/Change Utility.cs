using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeUtility : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject cursor;
    [SerializeField] private Sprite cursorSprite;
    [SerializeField, Range(0, 2)] private int utilityIndex = 0;

    private void OnMouseDown()
    {
        cursor.GetComponent<SpriteRenderer>().sprite = cursorSprite;
        gameManager.setUtility(utilityIndex);
    }
}
