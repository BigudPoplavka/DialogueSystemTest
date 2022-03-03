using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "Phrase")]
public class Phrase : ScriptableObject
{
    [SerializeField] private string _text;

    public string Text { get => _text; set => _text = value; }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
