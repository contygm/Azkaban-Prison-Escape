using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	public int introCount = 0;
	string[] introMessage = new string[3];
	private enum Items {pouch, wand, timeturner, mirror, freedom};

	// Use this for initialization
	void Start () 
	{
		introMessage[0] = "You're in a windowless prison cell fortified with sound-proof enchantments. " +
			"Your only reprieve from the tireless Dementor guards is your secret capability: \n" +
			"\nYou are an animagus. At will, you can turn into a hawk. \n \n" +
			"You can escape through your cell's bars, but only if the Dementors don't catch you...\n" +
			"Only if the other deranged imates don't see you...\n\n(hit space)";

		introMessage[1] = "With all the enchantments in place...there is no other choice...\n" +
			"\nYou. Must. Fly.\n" +
			"\nYour only tools are a knicked wand, a timerturner with 2 turns left, " +
			"an owl's bottomless travel pouch, and an enchanted two way mirror.\n\n" +
			"Your best friend has your mirror's match. They are waiting for you beyond the waters of Azkaban. " +
			"Your companion cannot wait long, but they will guide you as best they can. \n\n" +
			"Make hast dear friend... May your magic be swift and unpredictable \n\n(hit space)";

		introMessage[2] = "Use the LEFT ARROW and RIGHT ARROW to cycle through your options. \n" +
			"\nUse UP ARROW to select\n" +
			"\nUse DOWN ARROW to return an object\n" +
			"\nUse ENTER for actions\n" +
			"\nPay attention. You must hurry.\n";

		text.text = "Press the space bar.";
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space) && introCount < 3)
		{
			text.text = introMessage[introCount];
			introCount++;
		}
	}
}
