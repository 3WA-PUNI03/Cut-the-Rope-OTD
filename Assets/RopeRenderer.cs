using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class RopeRenderer : MonoBehaviour
{
    [SerializeField] LineRenderer _lineRenderer;
    [SerializeField] Transform _candy;
    private void Update()
    {
        _lineRenderer.positionCount = transform.childCount+1;
        for (int i = 0; i < transform.childCount; i++)
        {
            _lineRenderer.SetPosition(i, transform.GetChild(i).position);
            var hinge = transform.GetChild(i).GetComponent<HingeJoint2D>();
            if (hinge != null && hinge.connectedBody == null) break;
        }
        _lineRenderer.positionCount = transform.childCount+1;
        _lineRenderer.SetPosition(transform.childCount, _candy.position);

    }
}
