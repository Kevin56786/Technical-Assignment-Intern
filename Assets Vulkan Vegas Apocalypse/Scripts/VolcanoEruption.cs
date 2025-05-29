using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering.Universal;

public class VolcanoEruption : MonoBehaviour
{
    [Header("Particles")]
    [SerializeField] private ParticleSystem eruptionParticles;
    [SerializeField] private ParticleSystem glowParticles;

    [Header("Lighting")]
    [SerializeField] private Light2D eruptionLight;
    [SerializeField] private float lightIntensityMin = 0.5f;
    [SerializeField] private float lightIntensityMax = 1.5f;
    [SerializeField] private float lightFlickerSpeed = 5f;

    private void Start()
    {
        eruptionParticles.Play();
        glowParticles.Play();
    }

    private void Update()
    {
        // Мерцание света
        float noise = Mathf.PerlinNoise(Time.time * lightFlickerSpeed, 0);
        eruptionLight.intensity = Mathf.Lerp(lightIntensityMin, lightIntensityMax, noise);
    }
}
