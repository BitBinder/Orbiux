using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum STATS
{
    STR,
    MND,
    VIT,
    STAM,
    WILL
};

public class Stats : IStats {
	
	private Dictionary<STATS,int> entityStats;

	public Stats()
	{
		entityStats = new Dictionary<STATS, int>();
		entityStats.Add(STATS.STR,0);
		entityStats.Add(STATS.MND,0);
		entityStats.Add(STATS.VIT,0);
		entityStats.Add(STATS.STAM,0);
		entityStats.Add(STATS.WILL,0);

	}

	#region IStats implementation


	public Dictionary<STATS, int> GetStats ()
	{
		return this.entityStats;
	}


	public void SetStats (STATS stat, int val)
	{
		entityStats[stat] += val;
	}


	#endregion

}
