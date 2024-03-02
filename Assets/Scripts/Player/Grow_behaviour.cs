using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow_behaviour : MonoBehaviour
{
    private List<Transform> _segmensts;
    public Transform segmentPrefab;

    public int InitialSize = 5;
    void Start()
    {
        _segmensts = new List<Transform>
        {
            transform
        };

        for (int i = 1; i < this.InitialSize; i++) // need to be move it from here 
        {
            _segmensts.Add(Instantiate(this.segmentPrefab)); 
        }
    }
    private void Grow()
    {
        Transform segment = Instantiate(this.segmentPrefab);
        segment.position = _segmensts[_segmensts.Count - 1].position;

        _segmensts.Add(segment);

    }

    void FixedUpdate()
    {
        for (int i = _segmensts.Count - 1; i > 0; i--)
        {
            _segmensts[i].position = _segmensts[i - 1].position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Food")
        {
            Grow();
        }
    }
}
