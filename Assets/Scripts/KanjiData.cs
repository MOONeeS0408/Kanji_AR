using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "KanjiData", menuName = "AR/KanjiData")]
public class KanjiData : ScriptableObject
{
    public Sprite pictograma;
    public string kanji;
    public string significado;
    public string descripcion;
    public string kunyomi;
    public string kunyomiRomaji;
    public string onyomi;
    public string onyomiRomaji;
    public AudioClip audioClip;
}
