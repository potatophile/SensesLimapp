using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Material skyMaterial;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = skyMaterial;
    }

    IEnumerator TimetoWait()
    {
        yield return new WaitForSeconds(170);

        float sinValue = RenderSettings.skybox.GetFloat("_Exposure");

        sinValue = 0.2f * Mathf.Sin(Time.time * 0.6f) + 0.5f;
        //float clampedValue = Mathf.Clamp(sinValue, 0.3f, 0.5f);

        RenderSettings.skybox.SetFloat("_Exposure", sinValue);

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(TimetoWait());
    }
}
