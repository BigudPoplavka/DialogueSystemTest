using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "DialogueNode")]
public class DialogueNode : ScriptableObject
{
    [SerializeField] private Character _initiator;
    [SerializeField] private Phrase _dialoguePhrase;
    [SerializeField] private List<Answer> _answers;

    public Phrase DialoguePhrase { get => _dialoguePhrase; set => _dialoguePhrase = value; }
    public List<Answer> Answers { get => _answers; set => _answers = value; }
    public Character Initiator { get => _initiator; set => _initiator = value; }

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
