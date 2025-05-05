//=============================================================================

public class MRNSTR_D_ModifierStates : cmk.IMB.Scripting.ModClass
{
	protected override void Execute()
	{
		var json = ExtractJson<D_ModifierStates>();
		
		var Seed_NightGrowthSpeed = json.Rows.Find(x => x.Name == "Seed_NightGrowthSpeed");
		Seed_NightGrowthSpeed.GrantedStats.BasePlantedCropNightGrowthSpeed_IncPct = 20;
		
		var IceBox_Backpack_Spoil_Rate = json.Rows.Find(x => x.Name == "IceBox_Backpack_Spoil_Rate");
		IceBox_Backpack_Spoil_Rate.GrantedStats.BaseInventorySpoilRate_IncPct = -800;
	}
}

//=============================================================================
