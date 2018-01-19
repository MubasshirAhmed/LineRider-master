using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Line : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public EdgeCollider2D edgeCollider;

    private List<Vector2> _points;

    public void UpdateLine(Vector2 mousePosition)
    {
        if (_points == null)
        {
            _points = new List<Vector2>();
            SetPoint(mousePosition);
            return;
        }

        if (Vector2.Distance(_points.Last(), mousePosition) > 0.1f)
            SetPoint(mousePosition);
    }

    private void SetPoint(Vector2 point)
    {
        _points.Add(point);
        lineRenderer.positionCount = _points.Count;
        lineRenderer.SetPosition(_points.Count - 1, point);

        if (_points.Count > 1)
            edgeCollider.points = _points.ToArray();
    }
}
