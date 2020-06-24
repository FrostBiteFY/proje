using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject prefab;
    // public Camera mainCamera;
    public Camera cam;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 touchPos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));//mousenın positionunu aldı vector 3 e atadı.

            Instantiate(prefab, touchPos, Quaternion.identity);
        }
    }
}
