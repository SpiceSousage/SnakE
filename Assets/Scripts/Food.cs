using UnityEngine;

public class Food : MonoBehaviour
{
    public BoxCollider2D gridArea;
     void Start()
    {
        RandomizeFoodPisition();
    }

    private void RandomizeFoodPisition()
    {
        Bounds bounds = this.gridArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector2 (Mathf.Round(x), Mathf.Round(y));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            RandomizeFoodPisition ();
        }
    }
}
