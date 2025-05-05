//=============================================================================
// All rewards for missions are x10 times bigger
//=============================================================================


public class BetterRewards : cmk.IMB.Scripting.ModClass
{
	protected override void Execute()
	{
		var json = ExtractJson<D_FactionMissions>();
		foreach( var row in json.Rows ) {
			if( row.CurrencyRewarded != null )
				foreach( var reward in row.CurrencyRewarded )
					reward.Amount *= 10;

		}
	}
}

//=============================================================================
