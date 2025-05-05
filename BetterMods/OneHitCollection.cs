//=============================================================================

public class OneHitCollection : cmk.IMB.Scripting.ModClass
{
	protected override void Execute()
	{
		var talents = ExtractJson<D_Talents>();
		var Resources_Voxel_Instant = talents.Rows.FirstOrDefault(x => x.Name == "Resources_Voxel_Instant");
		var rewardMine = Resources_Voxel_Instant.Rewards.FirstOrDefault(x => x.GrantedStats.BaseChanceToMineVoxelInstantly_IncPct.HasValue);
		rewardMine.GrantedStats.BaseChanceToMineVoxelInstantly_IncPct = 90;
		
		var Resources_Instant_Tree = talents.Rows.FirstOrDefault(x => x.Name == "Resources_Instant_Tree");
		var rewardFell = Resources_Instant_Tree.Rewards.FirstOrDefault(x => x.GrantedStats.BaseChanceToFellTreeInstantly_Pct.HasValue);
		rewardMine.GrantedStats.BaseChanceToFellTreeInstantly_Pct = 90;
	}
}

//=============================================================================
