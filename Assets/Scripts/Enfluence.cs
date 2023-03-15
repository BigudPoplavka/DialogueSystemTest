using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Enfluence : MonoBehaviour
{
    [SerializeField] private List<DialogueNode> _enflDialogueNodes;

    public void AddPhrase(List<Answer> phrases)
    {
        foreach(DialogueNode dialogueNode in _enflDialogueNodes)
        {
             foreach(Answer phrase in phrases)
             {
                  dialogueNode.Answers.Add(phrase);
             }   
        }
    }

    public void RemovePhrase()
    {
        ///
    }
}
