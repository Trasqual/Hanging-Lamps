using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRender : MonoBehaviour
{
    LineRenderer lr;

    public List<Transform> lamps = new List<Transform>();
    Vector3[] positions = new Vector3[7];

    private void Start()
    {
        lr = GetComponent<LineRenderer>();


    }

    private void Update()
    {
        for (int i = 0; i < lamps.Count; i++)
        {
            positions[i] = lamps[i].position;
        }
        lr.SetPositions(positions);
    }
}
