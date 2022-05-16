using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessTemp : MonoBehaviour
{
    public float PostProcessTempHot;
    public float PostProcessTempCold;

    private ColorGrading ColorGrading;
    private PostProcessVolume volume;
    private void Start()
    {
        volume = GetComponent<PostProcessVolume>();
    }
    private void OnTriggerEnter(Collider other)
    {
        volume.profile.TryGetSettings(out ColorGrading);

        ColorGrading.temperature.value = PostProcessTempHot;
    }

    private void OnTriggerExit(Collider other)
    {
        ColorGrading.temperature.value = PostProcessTempCold;
    }
}
