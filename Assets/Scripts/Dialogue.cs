using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Dialogue : MonoBehaviour
{
    [SerializeField] private List<Character> _participants;
    [SerializeField] private List<DialogueNode> _dialogueNodes;
    [SerializeField] private DialogueNode _currentNode;
    [SerializeField] private int _currNodeIndex;

    [SerializeField] public static DialogueRenderer dialogueRenderer;
    [SerializeField] private GameObject _rendererOwner;

    public List<DialogueNode> DialogueNodes { get => _dialogueNodes; set => _dialogueNodes = value; }
    public int CurrNodeIndex { get => _currNodeIndex; set => _currNodeIndex = value; }
    public List<Character> Participants { get => _participants; set => _participants = value; }
    public DialogueNode CurrentNode { get => _currentNode; set => _currentNode = value; }

    public DialogueNode GetFirst() { return _dialogueNodes[0]; }

    void Start()
    {
        dialogueRenderer = _rendererOwner.GetComponent<DialogueRenderer>();
    }

    public void StartDialog()
    {
        CurrentNode = DialogueNodes[0];
        CurrNodeIndex = 0;

        ShowNode(CurrentNode);
    }

    public void ShowNode(DialogueNode dialogueNode)
    {
        Debug.Log(dialogueNode.name);
        dialogueRenderer.Render(dialogueNode);
    }
}
