using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimation : MonoBehaviour
{
    public Material cubeMat;
    public float transitionDuration = 1000f;

    public Renderer cubeRenderer;

    public void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
        StartCoroutine(ChangeMaterialOverTime());
    }

    IEnumerator ChangeMaterialOverTime()
    {
        Material newMat = cubeRenderer.material;
        float elapsedTime = 0f;

        while (elapsedTime < transitionDuration)
        {
            float lerpValue = elapsedTime / transitionDuration; // calcule lerp value

            cubeRenderer.material.Lerp(newMat, cubeMat, lerpValue); 

            elapsedTime += Time.deltaTime;

            yield return null; //wait for next frame
        }

        cubeRenderer.material = cubeMat;
    }
}
