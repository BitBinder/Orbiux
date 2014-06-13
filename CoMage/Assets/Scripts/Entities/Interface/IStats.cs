using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface IStats {

	Dictionary<STATS,int> GetStats();
	void SetStats(STATS stat, int val);
}
