//=============================================================================
// Use 1 ore per smelting operation, get x10 ingots as output, x10 times faster craft (but on practice it is not that faster)
//=============================================================================

public class BetterOreSmelting : cmk.IMB.Scripting.ModClass
{
	public long InputCountMax = 1;

	protected override void Execute()
	{
		var json = ExtractJson<D_ProcessorRecipes>();
		foreach( var row in json.Rows ) {
			if( row.Inputs  == null || row.Inputs.Count != 1 ) continue;
			if( row.Outputs == null || row.Outputs.Count != 1 ) continue;
			var ores = row.Inputs.FindAll(INPUT => INPUT.Element.RowName.Contains("Ore"));
			if(ores.Count > 0)
			{
				foreach( var ore in ores ) {
					if( ore.Count > InputCountMax ) 
						ore.Count = InputCountMax;
				}
				foreach(var output in row.Outputs)
					output.Count = 10;
				row.RequiredMillijoules /= 10;
			}
		}
	}
}

//=============================================================================
