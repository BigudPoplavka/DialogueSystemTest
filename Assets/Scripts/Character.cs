using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "Character")]
public class Character : ScriptableObject
{
    [SerializeField] private string _NPC_name;
    [SerializeField] private List<Phrase> _phrase;
    [SerializeField] private Sprite _icon;

    public string NPC_name { get => _NPC_name; set => _NPC_name = value; }
    public List<Phrase> Text { get => _phrase; set => _phrase = value; }
    public Sprite Icon { get => _icon; set => _icon = value; }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
