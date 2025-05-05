//=============================================================================

public class MRNSTR_D_ItemsStatic : cmk.IMB.Scripting.ModClass
{
	Dictionary<string, int> _sickles = new Dictionary<string, int>()
	{
		{"Sickle", 100},
		{"Titanium_Sickle", 200},
		{"Bone_Sickle", 120},
		{"Platinum_Sickle", 180},
		{"Obsidian_Sickle", 110},
		{"Cold_Steel_Sickle", 150},
		{"Iron_Wood_Sickle", 110},
	};
	
	protected override void Execute()
	{
		var json = ExtractJson<D_ItemsStatic>();
		
		var Machete = json.Rows.Find(x => x.Name == "Machete");
		Machete.AdditionalStats ??= new D_ItemsStatic.AdditionalStats_();
		Machete.AdditionalStats.BaseFireDamage_Inc = 20;
		
		var Combat_Knife = json.Rows.Find(x => x.Name == "Combat_Knife");
		Combat_Knife.AdditionalStats ??= new D_ItemsStatic.AdditionalStats_();
		Combat_Knife.AdditionalStats.BaseCriticalDamage_IncPct = 10;
		Combat_Knife.AdditionalStats.BaseAttacksCauseBleed_Pct = 25;
		Combat_Knife.AdditionalStats.BaseMovementSpeed_IncPct = 10;
		
		foreach(var sickle in _sickles)
		{
			var obj = json.Rows.Find(x => x.Name == sickle.Key);
			obj.AdditionalStats ??= new D_ItemsStatic.AdditionalStats_();
			obj.AdditionalStats.BaseReapingSeedRewards_IncPct = sickle.Value;
			obj.AdditionalStats.CanHarvestSeeds_0or1 = 1;
		}
	}
}

//=============================================================================
