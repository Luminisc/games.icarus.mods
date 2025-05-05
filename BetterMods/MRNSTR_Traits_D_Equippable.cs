//=============================================================================

public class MRNSTR_Traits_D_Equippable : cmk.IMB.Scripting.ModClass
{
	protected override void Execute()
	{
		var json = ExtractJson<D_Equippable>();
		
		var Backpack_Basic = json.Rows.Find(x => x.Name == "Backpack_Basic");
		Backpack_Basic.GrantedStats.BaseWeightCapacity_IncPct = 10;
		Backpack_Basic.GrantedStats.BaseBackpackSlots_Inc = 12;
		Backpack_Basic.GrantedStats.BasePhysicalDamageResistance_Pct = 5;
		Backpack_Basic.GrantedStats.BaseExposureResistance_IncPct = 20;
		Backpack_Basic.GrantedStats.BaseMovementSpeed_IncPct = 10;
	}
}

//=============================================================================
