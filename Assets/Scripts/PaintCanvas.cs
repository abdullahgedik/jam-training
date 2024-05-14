using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintCanvas : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject cam;

    private int colorIndex = 0;
    private bool canPaintCanvas = false;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && canPaintCanvas)
        {
            switch (colorIndex)
            {
                case 0:
                    cam.gameObject.GetComponent<Camera>().backgroundColor = Color.black;
                    break;
                case 1:
                    cam.gameObject.GetComponent<Camera>().backgroundColor = Color.red;
                    break;
                case 2:
                    cam.gameObject.GetComponent<Camera>().backgroundColor = Color.green;
                    break;
                case 3:
                    cam.gameObject.GetComponent<Camera>().backgroundColor = Color.blue;
                    break;
                case 4:
                    cam.gameObject.GetComponent<Camera>().backgroundColor = Color.white;
                    break;
                case 5:
                    cam.gameObject.GetComponent<Camera>().backgroundColor = new Color(1, 1, 0); //yellow
                    break;
                case 6:
                    cam.gameObject.GetComponent<Camera>().backgroundColor = new Color(0, 1, 1); //aqua
                    break;
                case 7:
                    cam.gameObject.GetComponent<Camera>().backgroundColor = new Color(1, 0, 1); //purple
                    break;
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
    public bool isBucketEnabled()
    {
        return canPaintCanvas;
    }
    public void enableBucket()
    {
        canPaintCanvas = true;
    }
    public void disableBucket()
    {
        canPaintCanvas = false;
    }
}
