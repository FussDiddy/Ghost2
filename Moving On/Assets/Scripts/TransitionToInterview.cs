using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TransitionToInterview : MonoBehaviour
{
	Text _text;
	TMP_Text _tmpProText;
	string writer;

	[SerializeField] float delayBeforeStart = 0f;
	[SerializeField] float timeBtwChars = 0.1f;
	[SerializeField] string leadingChar = "";
	[SerializeField] bool leadingCharBeforeDelay = false;

	public int nextRoundScene;
	public int deathScene;

	public ScoreManager scoreManager;

	public int passingScore;

	// Use this for initialization
	void Start()
	{
		_text = GetComponent<Text>()!;
		_tmpProText = GetComponent<TMP_Text>()!;

		if (_text != null)
		{
			writer = _text.text;
			_text.text = "";

			StartCoroutine("TypeWriterText");
		}

		if (_tmpProText != null)
		{
			writer = _tmpProText.text;
			_tmpProText.text = "";

			StartCoroutine("TypeWriterTMP");
		}

	}

	private void Update()
	{

		if (Input.GetKeyDown(KeyCode.Return))
		{
			SpeedText();
		}

		if (Input.GetKeyDown(KeyCode.KeypadEnter))
		{
			SpeedText();
		}
	}


	//Unused
	IEnumerator TypeWriterText()
	{
		_text.text = leadingCharBeforeDelay ? leadingChar : "";

		yield return new WaitForSeconds(delayBeforeStart);

		foreach (char c in writer)
		{
			if (_text.text.Length > 0)
			{
				_text.text = _text.text.Substring(0, _text.text.Length - leadingChar.Length);
			}
			_text.text += c;
			_text.text += leadingChar;
			yield return new WaitForSeconds(timeBtwChars);
		}

		if (leadingChar != "")
		{
			_text.text = _text.text.Substring(0, _text.text.Length - leadingChar.Length);
		}
	}

	//Animates text
	IEnumerator TypeWriterTMP()
	{
		_tmpProText.text = leadingCharBeforeDelay ? leadingChar : "";

		yield return new WaitForSeconds(delayBeforeStart);

		foreach (char c in writer)
		{
			if (_tmpProText.text.Length > 0)
			{
				_tmpProText.text = _tmpProText.text.Substring(0, _tmpProText.text.Length - leadingChar.Length);
			}
			_tmpProText.text += c;
			_tmpProText.text += leadingChar;
			yield return new WaitForSeconds(timeBtwChars);

		}

		//Send player to next round or to death scene based on score
		if (scoreManager.score > passingScore)
		{
			StartCoroutine(MoveToNextRound(nextRoundScene));
		}
		else
		{
			StartCoroutine(MoveToDeathScene(deathScene));
		}


		//Unused
		if (leadingChar != "")
		{
			_tmpProText.text = _tmpProText.text.Substring(0, _tmpProText.text.Length - leadingChar.Length);
		}
	}

	//Waits for 3 seconds then sends player to the next round
	IEnumerator MoveToNextRound(int level)
	{
		//Wait
		yield return new WaitForSeconds(3);
		//Then the load the scene
		SceneManager.LoadScene(level);
	}

	//Waits for 3 seconds then sends player to the death scene
	IEnumerator MoveToDeathScene(int level)
    {
		//Wait
		yield return new WaitForSeconds(3);
		//Then the load the scene
		SceneManager.LoadScene(level);
	}

	private void SpeedText()
	{
		timeBtwChars = .0001f;
	}
}
