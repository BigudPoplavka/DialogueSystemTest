using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerButton : MonoBehaviour
{
    [SerializeField] private DialogueNode _answerDialogueNode;
    [SerializeField] private Dialogue _dialogue;

    public DialogueNode AnswerDialogueNode { get => _answerDialogueNode; set => _answerDialogueNode = value; }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ShowLinkNode()
    {
        if(_answerDialogueNode != null)
        {
            Debug.Log(_answerDialogueNode.name);
            _dialogue.ShowNode(AnswerDialogueNode);
        }
    }
}
