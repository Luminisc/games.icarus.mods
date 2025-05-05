//=============================================================================

public class MRNSTR_D_CharacterStartingStats : cmk.IMB.Scripting.ModClass
{
	protected override void Execute()
	{
		var json = ExtractJson<D_CharacterStartingStats>();
		json.Rows.First().StatsGranted.BaseWeightCapacity_Inc = 250;
	}
}

//=============================================================================
