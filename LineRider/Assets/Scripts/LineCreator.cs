using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreator : MonoBehaviour
{

    public GameObject linePrefab;
    private Line _activeLine;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject lineGO = Instantiate(linePrefab);
            _activeLine = lineGO.GetComponent<Line>();
        }

        if (Input.GetMouseButtonUp(0))
            _activeLine = null;

        if (_activeLine != null)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _activeLine.UpdateLine(mousePosition);
        }
    }
}
