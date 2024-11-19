using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanjiManager : MonoBehaviour
{
    public Dictionary<string, KanjiData> kanjiDictionary = new Dictionary<string, KanjiData>();
    public List<KanjiData> kanjiDataList;

    void Start()
    {
        foreach (KanjiData kanjiData in kanjiDataList)
        {
            // Asegúrate de que el kanji sea la clave correcta
            kanjiDictionary[kanjiData.kanji] = kanjiData; // Usa el valor del kanji como clave
        }
    }
}
