using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class ChangeColor : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private LineGenerator lineGenerator;
    [SerializeField] private PaintCanvas paintCanvas;
    [SerializeField] private GameObject cursor;

    [Header("Settings")]
    [SerializeField, Range(0,7)] private int colorIndex;

    private void OnMouseDown()
    {
        if (lineGenerator.isDrawingEnabled())
        {
            lineGenerator.setColor(colorIndex);
        }
        if(paintCanvas.isBucketEnabled())
        {
            paintCanvas.setColor(colorIndex);
        }

        if (lineGenerator.isDrawingEnabled() || paintCanvas.isBucketEnabled())
        {
            switch (colorIndex)
            {
                case 0:
                    cursor.GetComponent<SpriteRenderer>().color = Color.black;
                    break;
                case 1:
                    cursor.GetComponent<SpriteRenderer>().color = Color.red;
                    break;
                case 2:
                    cursor.GetComponent<SpriteRenderer>().color = Color.green;
                    break;
                case 3:
                    cursor.GetComponent<SpriteRenderer>().color = Color.blue;
                    break;
                case 4:
                    cursor.GetComponent<SpriteRenderer>().color = Color.white;
                    break;
                case 5:
                    cursor.GetComponent<SpriteRenderer>().color = new Color(1, 1, 0); //yellow
                    break;
                case 6:
                    cursor.GetComponent<SpriteRenderer>().color = new Color(0, 1, 1); //aqua
                    break;
                case 7:
                    cursor.GetComponent<SpriteRenderer>().color = new Color(1, 0, 1); //purple
                    break;
            }
        }
    }
}
