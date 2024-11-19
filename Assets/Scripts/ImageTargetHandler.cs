using UnityEngine;
using Vuforia;

public class ImageTargetHandler : MonoBehaviour
{
    public Canvas uiCanvas;
    public KanjiDisplayManager kanjiDisplayManager;
    public string trackerName;

    void Start()
    {
        uiCanvas.enabled = false;
    }

    public void OnTrackingFound()
    {
        uiCanvas.enabled = true;
        kanjiDisplayManager.DisplayKanji(trackerName); // Mostrar datos del kanji
        Debug.Log("Image Target detectado.");
    }

    public void OnTrackingLost()
    {
        uiCanvas.enabled = false;
        kanjiDisplayManager.ClearDisplay(); // Limpiar datos cuando se pierda el tracker
        Debug.Log("Image Target perdido.");
    }
}
