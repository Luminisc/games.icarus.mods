//=============================================================================
// Makes mining ore deposits x10 times faster
//=============================================================================


public class BetterMiningDeposits : cmk.IMB.Scripting.ModClass
{
	protected override void Execute()
	{
		var json = ExtractJson<D_OreDeposit>();
		foreach( var row in json.Rows ) {
			if(row.MiningTimeSeconds.HasValue)
				row.MiningTimeSeconds /= 10;
		}
	}
}

//=============================================================================
