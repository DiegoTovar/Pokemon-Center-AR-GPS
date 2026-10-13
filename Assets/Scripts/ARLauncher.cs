using System;
using System.Text.Json.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARLauncher : MonoBehaviour
{
    [SerializeField] private SceneSelector sceneSelector;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"POI colisionado: {other.gameObject.name}");
        sceneSelector.SetScene(0);
    }
}