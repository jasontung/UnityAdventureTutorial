using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

// This class is used to manage the text that is
// displayed on screen.  In situations where many
// messages are triggered one after another it
// makes sure they are played in the correct order.
public class TextManager : MonoBehaviour
{
    public struct Instruction
    {
        public string message;
        public Color textColor;
        public float startTime;
    }

    public Text text;
    public float displayTimePerCharacter = 0.1f;
    public float additionalDisplayTime = 0.5f;
    private List<Instruction> instructions = new List<Instruction>();
    private float clearTime;
	private void Update()
	{
        if (instructions.Count > 0 && Time.time >= instructions[0].startTime)
        {
            text.text = instructions[0].message;
            text.color = instructions[0].textColor;
            instructions.RemoveAt(0);
        }
        else if (Time.time >= clearTime)
            text.text = string.Empty;
	}
	// This function is called from TextReactions in order to display a message to the screen.
	public void DisplayMessage (string message, Color textColor, float delay)
    {
        float startTime = Time.time + delay;
        float displayDuration = message.Length * displayTimePerCharacter + additionalDisplayTime;
        float newClearTime = startTime + displayDuration;
        if (newClearTime > clearTime)
            clearTime = newClearTime;
        Instruction newInstruction = new Instruction
        {
            message = message,
            textColor = textColor,
            startTime = startTime
        };
        instructions.Add(newInstruction);
    }
}

