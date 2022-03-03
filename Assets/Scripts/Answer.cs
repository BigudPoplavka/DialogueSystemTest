using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnAnswerSelected : UnityEvent<DialogueNode> { }

[System.Serializable]
[CreateAssetMenu(menuName = "Answer")]
public class Answer : ScriptableObject
{
    [SerializeField] private Phrase _answerText;        // variant 1
    [SerializeField] private string _text;              // variant 2
    [SerializeField] private DialogueNode _linkNode;    // variant 2
    [SerializeField] private bool _isEndDialog;

    [SerializeField] public delegate void AnswerAction();
    [SerializeField] public OnAnswerSelected answerSelected;
    public AnswerAction answerAction;

    public UnityAction answerClickAction;

    public Phrase AnswerText { get => _answerText; set => _answerText = value; }
    public DialogueNode LinkNode { get => _linkNode; set => _linkNode = value; }
    public bool IsEndDialog { get => _isEndDialog; set => _isEndDialog = value; }
    public string Text { get => _text; set => _text = value; }

    void Start()
    {
        answerAction = ApplyAnswerAction;
        answerSelected = new OnAnswerSelected();

        answerClickAction = new UnityAction(ApplyAnswerAction);
    }

    void Update()
    {
        
    }

    public void ApplyAnswerAction()
    {
        answerSelected?.Invoke(_linkNode);
    }
}
