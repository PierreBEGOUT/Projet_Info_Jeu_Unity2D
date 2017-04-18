using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyMvtY : MonoBehaviour
{
    public float speed;
    public float weigth;
    public float frequency;
    public float amplitude;

    float currentTime;

    // Use this for initialization
    void Start()
    {
        currentTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (WaveY(weigth, frequency, amplitude) * Time.deltaTime) * speed;
    }

    public Vector3 WaveY(float weight, float frequency, float amplitude)
    {
        float time = Time.time - currentTime;
        float offsetY = Mathf.Sin(time * frequency) * amplitude;

        Vector3 direction = new Vector3(0.0f, offsetY, 0.0f);
        return direction * weight;
    }
}
