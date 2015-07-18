using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class PlayerCharacters {

	static Character[] characters = new Character[]{
		new Character ("knight", 10f, 1, 5, 100),
		new Character ("knight", 10f, 1, 5, 100),
		new Character ("knight", 10f, 1, 5, 100),
		new Character ("knight", 10f, 1, 5, 100)
	};

}

public struct Character {

	string characterName;
	float movementSpeed;
	int baseDamage;
	int baseHealth;
	int skillCooldownPercentage;

	public Character(string characterName, float movementSpeed, int baseDamage, int baseHealth, int skillCooldownPercentage) {
		this.characterName = characterName;
		this.movementSpeed = movementSpeed;
		this.baseDamage = baseDamage;
		this.baseHealth = baseHealth;
		this.skillCooldownPercentage = skillCooldownPercentage;
	}

}