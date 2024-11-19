using System.Collections;
using UnityEngine;

public class ModelSwitcher : MonoBehaviour
{
    public GameObject model1; // Primer modelo 3D
    public GameObject model2; // Segundo modelo 3D
    public float switchInterval = 5f; // Intervalo de tiempo en segundos

    private IEnumerator switchCoroutine; // Corrutina de alternancia
    private bool isTracking = false; // Indica si el ImageTarget está siendo detectado

    void Start()
    {
        // Asegúrate de que solo el primer modelo sea visible al inicio
        model1.SetActive(true);
        model2.SetActive(false);
    }

    public void OnTrackingFound()
    {
        Debug.Log("Tracking found!");
        isTracking = true;
        if (switchCoroutine == null)
        {
            switchCoroutine = SwitchModels();
            StartCoroutine(switchCoroutine);
        }
    }

    public void OnTrackingLost()
    {
        Debug.Log("Tracking lost!");
        isTracking = false;
        if (switchCoroutine != null)
        {
            StopCoroutine(switchCoroutine);
            switchCoroutine = null;

            // Restablece el estado inicial
            model1.SetActive(true);
            model2.SetActive(false);
        }
    }
    private IEnumerator SwitchModels()
    {
        while (isTracking)
        {
            Debug.Log("SwitchModels running...");
            yield return new WaitForSeconds(switchInterval);

            // Alternar modelos
            bool isModel1Active = model1.activeSelf;
            model1.SetActive(!isModel1Active);
            model2.SetActive(isModel1Active);

            Debug.Log($"Model 1 active: {model1.activeSelf}, Model 2 active: {model2.activeSelf}");
        }

        Debug.Log("SwitchModels stopped (isTracking false).");
    }


}
