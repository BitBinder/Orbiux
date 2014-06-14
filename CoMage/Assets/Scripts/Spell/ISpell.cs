using UnityEngine;
using System.Collections;

public interface ISpell {

	string[] GetSpellCombo();
	void SetSpellName(string name);
	string GetSpellName();
	void SetSpellCost(float cost);
	float GetSpellcost();
	string GetSpellDescription();
	void SetSpellDescription(string description);
	float GetSpellDamage();
	void SetSpellDamage(float damage);
	void SetSpellStatusEffect(IStatusEffect effect);

}
