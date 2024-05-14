using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private LineGenerator lineGenerator;
    [SerializeField] private PaintCanvas paintCanvas;
    [SerializeField] private Eraser eraser;

    public void setUtility(int utilityIndex)
    {
        switch (utilityIndex)
        {
            case 0:
                paintCanvas.enableBucket();
                lineGenerator.disableDrawing();
                eraser.disableEraser();
                break;
            case 1:
                paintCanvas.disableBucket();
                lineGenerator.enableDrawing();
                eraser.disableEraser();
                break;
            case 2:
                paintCanvas.disableBucket();
                lineGenerator.disableDrawing();
                eraser.enableEraser();
                break;
        }
    }
}
