using UnityEngine;
using UnityEngine.UI;

public class KanjiDisplayManager : MonoBehaviour
{
    public Image pictogramaImage;
    public Text kanjiText;
    public Text significadoText;
    public Text descripcionText;
    public Text onyomiText;
    public Text onyomiRomajiText;
    public Text kunyomiText;
    public Text kunyomiRomajiText;
    public AudioSource audioSource;

    private KanjiManager kanjiManager;

    void Start()
    {
        kanjiManager = FindObjectOfType<KanjiManager>();
    }

    public void DisplayKanji(string trackerName)
    {
        if (kanjiManager.kanjiDictionary.TryGetValue(trackerName, out KanjiData kanjiData))
        {
            // Verifica si el pictograma está asignado y lo muestra solo si existe
            if (kanjiData.pictograma != null)
            {
                pictogramaImage.sprite = kanjiData.pictograma;
                pictogramaImage.gameObject.SetActive(true); // Mues tra el pictograma
            }
            else
            {
                pictogramaImage.gameObject.SetActive(false); // Oculta el pictograma si no está asignado
            }

            kanjiText.text = kanjiData.kanji;
            significadoText.text = kanjiData.significado;
            descripcionText.text = kanjiData.descripcion;
            onyomiText.text = kanjiData.onyomi;
            onyomiRomajiText.text = kanjiData.onyomiRomaji;
            kunyomiText.text = kanjiData.kunyomi;
            kunyomiRomajiText.text = kanjiData.kunyomiRomaji;
            audioSource.clip = kanjiData.audioClip;
        }
        else
        {
            Debug.LogWarning("Kanji Data not found for: " + trackerName);
        }
    }


    public void ClearDisplay()
    {
        pictogramaImage.sprite = null; // Limpia el pictograma
        kanjiText.text = "";
        significadoText.text = "";
        descripcionText.text = "";
        onyomiText.text = "";
        onyomiRomajiText.text = "";
        kunyomiText.text = "";
        kunyomiRomajiText.text = "";

        audioSource.clip = null; // Limpia el audio
    }

    public void PlayAudio()
    {
        if (audioSource.clip != null)
        {
            audioSource.Play();
        }
    }
}
