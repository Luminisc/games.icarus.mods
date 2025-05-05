//=============================================================================

public class MRNSTR_Traits_D_Fillable : cmk.IMB.Scripting.ModClass
{	
	Dictionary<string, int> changes = new Dictionary<string, int>()
	{
		{"Jerrycan", 25000},
		{"Biofuel_Lamp", 5000},
		{"Meta_Biofuel_Can", 20000},
		{"Battery_Shelf_T4", 10000000},
		{"Flashlight", 12000},
		{"Icebox_Backpack", 20000},
		{"Battery_Lamp", 12000},
		{"Milk_Bucket", 10000},
		{"Fillable_Water_5L", 8000},
		{"Fillable_Water_6_5L", 10000},
	};
	
	protected override void Execute()
	{
		var json = ExtractJson<D_Fillable>();
		
		foreach(var change in changes)
		{
			var obj = json.Rows.Find(x => x.Name == change.Key);
			obj.MaximumStoredUnits = change.Value;
		}
	}
}

//=============================================================================
