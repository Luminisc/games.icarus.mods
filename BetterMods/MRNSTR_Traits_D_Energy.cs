//=============================================================================

public class MRNSTR_Traits_D_Energy : cmk.IMB.Scripting.ModClass
{
	Dictionary<string, int> changes = new Dictionary<string, int>()
	{
		{"Generator", 6000},
		{"SolarPanel", 8000},
		{"WaterWheel_Generator", 2500},
		{"WindTurbine", 3000},
	};
	
	protected override void Execute()
	{
		var json = ExtractJson<D_Energy>();
		
		foreach(var change in changes)
		{
			var obj = json.Rows.Find(x => x.Name == change.Key);
			obj.ResourceFlowRate = change.Value;
		}
	}
}

//=============================================================================
