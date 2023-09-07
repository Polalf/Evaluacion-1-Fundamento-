using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anzuelo : MonoBehaviour
{
    Vector3 velocity = Vector3.zero;
    [SerializeField] float smoothTime;
    float currentSmoothTime;
    [SerializeField] float maxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        currentSmoothTime = smoothTime;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 pos =Vector3.SmoothDamp(transform.position,target,ref velocity, currentSmoothTime, maxSpeed);
        transform.position = pos;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Fish"));
        {
            StartCoroutine(DismVel());
        }
    }
    IEnumerator DismVel()
    {
        for (float i = 0; i < 1f; i+= Time.deltaTime)
        {
            currentSmoothTime = 0.5f;
            yield return null;
        }
        currentSmoothTime = smoothTime;
    }
}
