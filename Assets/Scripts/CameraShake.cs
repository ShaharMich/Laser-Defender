using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] float shakeDur = 1f;
    [SerializeField] float shakeMag = 0.5f;

    Vector3 initPos;

    void Start()
    {
        initPos = transform.position;
    }

    public void Play()
    {
        StartCoroutine(Shake());
    }

    IEnumerator Shake()
    {
        float elapsedTime = 0;
        while(elapsedTime < shakeDur)
        {
        transform.position = initPos + (Vector3)Random.insideUnitCircle * shakeMag;
        elapsedTime += Time.deltaTime;
        yield return new WaitForEndOfFrame();
        }
    }

}
