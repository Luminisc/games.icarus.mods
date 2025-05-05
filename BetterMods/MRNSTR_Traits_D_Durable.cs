//=============================================================================

public class MRNSTR_Traits_D_Durable : cmk.IMB.Scripting.ModClass
{
	Dictionary<string, int> durabilities = new Dictionary<string, int>()
	{
		{"Rifle_Hunting", 12000},
		{"Shotgun", 12000},
		{"Rifle_BoltAction", 10000},
		{"Lantern", 7000},
		{"Shotgun_T4", 18000},
		{"Pistol_T3", 10000},
		{"Pistol_T4", 18000},
		{"Submachine_Gun", 48000},
		{"Rifle_Assault_T4", 60000},
	};
	
	protected override void Execute()
	{
		var json = ExtractJson<D_Durable>();
		
		foreach(var dura in durabilities)
		{
			var obj = json.Rows.Find(x => x.Name == dura.Key);
			obj.Max_Durability = dura.Value;
		}
	}
}

//=============================================================================
