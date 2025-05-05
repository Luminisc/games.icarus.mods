//=============================================================================
// Makes small wooden crates bigger (100 slots)
//=============================================================================


public class BetterSmallCrate : cmk.IMB.Scripting.ModClass
{
	protected override void Execute()
	{
		var json = ExtractJson<D_InventoryInfo>();
		var Storage_Wood_Crate_Small = json.Rows.FirstOrDefault(x => x.Name == "Storage_Wood_Crate_Small");
		Storage_Wood_Crate_Small.StartingSlots = 100;
	}
}

//=============================================================================
