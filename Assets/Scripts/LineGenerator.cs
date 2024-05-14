using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineGenerator : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject[] linePrefabs;
    [SerializeField] private Transform lineParent;

    private bool canDraw = true;
    int colorIndex = 0;
    Line activeLine;

    private void Update()
    {
        if (canDraw)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject newLine = Instantiate(linePrefabs[colorIndex]);
                newLine.transform.parent = lineParent;
                activeLine = newLine.GetComponent<Line>();
            }

            if (Input.GetMouseButtonUp(0))
            {
                activeLine = null;
            }

            if (activeLine != null)
            {
                Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                activeLine.UpdateLine(mousePosition);
            }
        }
    }

    public void setColor(int index)
    {
        // 0 for black
        // 1 for red
        // 2 for green
        // 3 for blue
        // 4 for white
        // 5 for yellow
        // 6 for aqua
        // 7 for purple

        colorIndex = index;
    }

    public bool isDrawingEnabled()
    {
        return canDraw;
    }
    public void enableDrawing()
    {
        canDraw = true;
    }
    public void disableDrawing()
    {
        canDraw = false;
    }
}
