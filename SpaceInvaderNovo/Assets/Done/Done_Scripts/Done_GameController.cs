﻿using UnityEngine;
using System.Collections;

public class Done_GameController : MonoBehaviour
{
	public GameObject[] hazards;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	
	public GUIText scoreText;
	public GUIText lifeText;
	public GUIText restartText;
	public GUIText gameOverText;
	
	private bool gameOver;
	private bool restart;
	private int score;
	private int life;
	
	void Start ()
	{
		gameOver = false;
		restart = false;
		restartText.text = "";
		gameOverText.text = "";
		lifeText.text = "";
		score = 0;
		life = 2;
		UpdateScore ();
		UpdateLife();
		StartCoroutine (SpawnWaves ());
	}
	
	void Update ()
	{
		if (restart)
		{
			if (Input.GetKeyDown (KeyCode.R))
			{
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}
	
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				GameObject hazard = hazards [Random.Range (0, hazards.Length)];
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
			
			if (gameOver)
			{
				restartText.text = "Pressione 'R' para reiniciar. \n e a tecla <Ctrl> para atirar!";
				restart = true;
				break;
			}
		}
	}
	
	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
		if(score >=50) {
			Application.LoadLevel ("Fase2");
		}
	}
	
	void UpdateScore ()
	{
		scoreText.text = "Pontos: " + score;
	}
	public void loseLife ()
	{
		life = life - 1;
		UpdateLife();
	}

	void UpdateLife ()
	{
		lifeText.text = "Vidas: " + life;
	}

	public int getLifeValue(){
		return life;
	}



	public void GameOver ()
	{
		gameOverText.text = "Fim de jogo!";
		gameOver = true;
	}
}