﻿using UnityEngine;
using System.Collections;

public class EnemyLevel : MonoBehaviour {
	// level attributes
	public int level, scoreLevel;

	// other reqiured scripts
	private EnemyAttack enemyAttack;
	private EnemyEnergy enemyEnergy;
	private EnemyScore enemyScore;

	// initialize level attribute
	void Awake() {
		enemyAttack = GetComponent<EnemyAttack> ();
		enemyEnergy = GetComponent<EnemyEnergy> ();
		enemyScore = GetComponent<EnemyScore> ();
	}

	// update current level
	void Update() {
		if (enemyScore.getScore () >= scoreLevel) // check if the player can level up or not
			levelUP ();
	}

	// level up
	public void levelUP() {
		/*
		 * if the score >= the score required to level up(lvlScore), the player will level up.
		 * the lvlScore will be multiplied by 3
		 */

		level++;
		scoreLevel *= 3;

		switch (level) {
		case 1:
			enemyEnergy.setMaxEnergy (110);
			enemyAttack.setAtk (2);
			break;
		case 2:
			enemyEnergy.setMaxEnergy (120);
			enemyAttack.setAtk (3);
			break;
		case 3:
			enemyEnergy.setMaxEnergy (130);
			enemyAttack.setAtk (4);
			break;
		case 4:
			enemyEnergy.setMaxEnergy (140);
			enemyAttack.setAtk (5);
			break;
		case 5:
			enemyEnergy.setMaxEnergy (150);
			enemyAttack.setAtk (6);
			break;
		}
	}

	// setter & getter
	public void setLevel(int amount) { level = amount; }
	public void setScoreLevel(int amount) { scoreLevel = amount; }

	public int getLevel() { return level; }
	public int getScoreLevel() { return scoreLevel; }
}