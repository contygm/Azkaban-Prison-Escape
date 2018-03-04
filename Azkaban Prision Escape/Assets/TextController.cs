using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	public int introCount = 0;
	string[] introMessage = new string[3];
	private enum States {wand, timeturner, mirror, freedom, cell, intro, invisible, hawk, patronous};
	private States myState; 
	private object pouch; 

	// Use this for initialization
	void Start () 
	{
		myState = States.intro;

		introMessage[0] = "You're in a windowless prison cell fortified with sound-proof enchantments. " +
			"Your only reprieve from the tireless Dementor guards is your secret capability: \n" +
			"\nYou are an animagus. At will, you can turn into a hawk. \n \n" +
			"You can escape through your cell's bars, but only if the Dementors don't catch you...\n" +
			"Only if the other deranged imates don't see you...\n\n>>>>> (hit space)";

		introMessage[1] = "With all the enchantments in place...there is no other choice...\n" +
			"\nYou. Must. Fly.\n" +
			"\nYour only tools are a knicked wand, a timerturner with 2 turns left, " +
			"an owl's bottomless travel pouch, and an enchanted two way mirror.\n\n" +
			"Your best friend has your mirror's match. They are waiting for you beyond the waters of Azkaban. " +
			"Your companion cannot wait long, but they will guide you as best they can. \n\n" +
			"Make hast dear friend... May your magic be swift and unpredictable \n\n>>>>>";

		introMessage[2] = "Use the LEFT ARROW and RIGHT ARROW to cycle through your options. \n" +
			"\nUse UP ARROW to select\n" +
			"\nUse DOWN ARROW to return an object\n" +
			"\nUse ENTER for actions\n" +
			"\nPay attention. You must hurry.\n\n>>>>>";

		text.text = "Press the spacebar.";

	}
	
	// Update is called once per frame
	void Update () 
	{
		state_cell();
	}

	void state_cell () {
		int mirrorCnt = 0;
		if(introCount < 3 && Input.GetKeyDown(KeyCode.Space))
		{
			text.text = introMessage[introCount];
			introCount++;
		}

		if(introCount == 3 && myState == States.intro)
		{
			text.text = "IN CELL STATE";
			myState = States.cell;
		}

		if(States.cell)
		{
			text.text = "You've got your wand. Cast your spell quickly!";

			if(Input.GetKeyDown(KeyCode.UpArrow))
			{
				myState = States.hawk;
			}
		}

		if(States.wand)
		{
			text.text = "You've got your wand. Cast your spell quickly!";

			if(Input.GetKeyDown(KeyCode.KeypadEnter))
			{
				myState = States.invisible;
			}

			if(Input.GetKeyDown(KeyCode.Space))
			{
				myState = States.patronous;
			}
		}

		if(States.mirror)
		{
			text.text = "Dear friend,\n\n"
				"To cast your invisibility spell, hit ENTER twice. \n\n" +
				"To cast a patronous, hit ENTER + SPACEBAR. \n\n" +
				"To change into a hawk, press SPACEBAR + UP ARROW. \n\n" + 
				"To change fly as a hawk, press SPACEBAR + UP ARROW again. \n\n" +
				"You will have to wait for the right moment to cast your spells and fly. "+
				"Be quick and take all your items with you or they'll catch us before Bristol. " +
				"Press ENTER to put the mirror in your pouch. GO!";

			if(Input.GetKeyDown(KeyCode.DownArrow))
			{
				myState = States.cell;
			}
		}

		if(States.hawk)
		{
			text.text = "You've got your wand. Cast your spell quickly!";

			if(Input.GetKeyDown(KeyCode.UpArrow))
			{
				myState = States.fly;
			}
		}
	}
}
