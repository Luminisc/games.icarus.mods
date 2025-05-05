//=============================================================================

public class MRNSTR_D_InventoryInfo : cmk.IMB.Scripting.ModClass
{
	Dictionary<string, int> containersSlots = new Dictionary<string, int>()
	{
		{"Container", 24},
		{"Storage_Metal_Crate_Medium", 30},
		{"Deep_Freeze", 30},
	};

	protected override void Execute()
	{
		var json = ExtractJson<D_InventoryInfo>();
		foreach(var container in containersSlots)
		{
			var obj = json.Rows.Find(x => x.Name == container.Key);
			obj.StartingSlots = container.Value;
		}
	}
}

//=============================================================================
