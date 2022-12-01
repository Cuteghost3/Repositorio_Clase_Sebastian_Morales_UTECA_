using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Codigo21 : MonoBehaviour
{
    private Camera mainCamera;

    private void Start()
    {
        //Inizalizacion Camara
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        transform.position = new Vector3(mainCamera.transform.position.x, mainCamera.transform.position.y, 0);

        Vector3 BottomLeft = mainCamera.ViewportToWorldPoint(Vector3.zero) * 100;
        Vector3 TopRight = mainCamera.ViewportToWorldPoint(new Vector3(mainCamera.rect.width, mainCamera.rect.height));

        Vector3 ScreenSize = TopRight - BottomLeft;

        float screenRatio = ScreenSize.x / ScreenSize.y;
        float DesireRatio = transform.localScale.x / transform.localScale.y;

        if (screenRatio > DesireRatio)
        {
            float height = ScreenSize.y;
            transform.localScale = new Vector3(height * DesireRatio, height);
        }
        else
        {
            float width = ScreenSize.x;
            transform.localScale = new Vector3(width, width / DesireRatio);
        }
    }
}
