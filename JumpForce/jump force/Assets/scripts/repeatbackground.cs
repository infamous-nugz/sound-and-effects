using UnityEngine;

public class repeatbackground : MonoBehaviour
{
    private Vector3 startpos;
    private float repeatWidth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startpos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startpos.x - repeatWidth)
        {
            transform.position = startpos;
        }
    }
}