using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Events;

public class DialogueRenderer : MonoBehaviour
{
    [SerializeField] private GameObject _dialoguePanel;

    [SerializeField] private TMPro.TMP_Text _NPCnameText;
    [SerializeField] private TMPro.TMP_Text _phraseText;
    [SerializeField] private Image _characterIcon;
    [SerializeField] private GameObject _answerTemplate;

    [SerializeField] private List<GameObject> _answersButtons;

    [SerializeField] private Dialogue _dialogue;

    private Image _imageComponent;

    public TMP_Text NPCnameText { get => _NPCnameText; set => _NPCnameText = value; }
    public TMP_Text PhraseText { get => _phraseText; set => _phraseText = value; }
    public Image CharacterIcon { get => _imageComponent; set => _imageComponent = value; }
    public GameObject AnswerTemplate { get => _answerTemplate; set => _answerTemplate = value; }
    public List<GameObject> AnswersButtons { get => _answersButtons; set => _answersButtons = value; }
    public Dialogue Dialogue { get => Dialogue1; set => Dialogue1 = value; }
    public Dialogue Dialogue1 { get => _dialogue; set => _dialogue = value; }

    void Start()
    {
        //_imageComponent = _characterIcon.GetComponent<Image>();

    }

    public void ChangeDialogPanelShowState()
    {
        _dialoguePanel.SetActive(!_dialoguePanel.activeSelf);
        Render(Dialogue1.GetFirst());
    }

    public void Render(DialogueNode dialogueNode)
    {
        //CharacterIcon.sprite = dialogueNode.Initiator.Icon;
        NPCnameText.text = dialogueNode.Initiator.NPC_name;
        PhraseText.text = dialogueNode.DialoguePhrase.Text;
        
        for(int i = 0; i < dialogueNode.Answers.Count; i++)
        {
            AnswersButtons[i].SetActive(true);
            AnswersButtons[i].GetComponentInChildren<TMPro.TMP_Text>().text = dialogueNode.Answers[i].Text;
            AnswersButtons[i].GetComponent<AnswerButton>().AnswerDialogueNode = dialogueNode.Answers[i].LinkNode;
        }

        for(int i = dialogueNode.Answers.Count; i < AnswersButtons.Count; i++)
        {
            AnswersButtons[i].SetActive(false);
        }
    }
}
