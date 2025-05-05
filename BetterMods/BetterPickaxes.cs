//=============================================================================
// Makes all pickaxes mine wider, mine more, damage nasty creatures better
//=============================================================================


public class BetterPickaxes : cmk.IMB.Scripting.ModClass
{
	protected override void Execute()
	{
		var tooldamages = ExtractJson<D_ToolDamage>();
		var pickaxes = tooldamages.Rows.Where(x => x.Mining_Efficiency != null).ToList();

		foreach(var pick in pickaxes)
		{
			pick.Mining_Radius *= 10;
			pick.Mining_Efficiency *= 10;
			pick.Melee_Damage *= 10;
		}
	}
}

//=============================================================================
