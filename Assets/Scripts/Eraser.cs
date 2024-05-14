using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Eraser : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private CircleCollider2D circleCollider;

    private bool canErase = false;

    private void Update()
    {
        if (canErase)
        {
            if (Input.GetMouseButton(0))
            {
                circleCollider.enabled = true;
            }
            if (Input.GetMouseButtonUp(0))
            {
                circleCollider.enabled = false;
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.tag == "Line")
        {
            Destroy(collision.gameObject);
        }
    }

    public bool isEraserActive()
    {
        return canErase;
    }
    public void enableEraser()
    {
        canErase = true;
    }
    public void disableEraser()
    {
        canErase = false;
    }

    private void OnDrawGizmos()
    {
        
    }
}
