//=============================================================================

public class MRNSTR_D_Mounts : cmk.IMB.Scripting.ModClass
{
	string[] animalsToChange = new string[] {
		"Wolf",
		"Snow_Wolf",
		"Wolf_Desert",
		"Wild_Boar",
		"Cow",
	};
	
	string[] newMovementStates = new string[] {
		"IdleStanding",
		"IdleLying",
	};
	
	protected override void Execute()
	{
		var json = ExtractJson<D_Mounts>();
		var animals = json.Rows.Where(x => animalsToChange.Contains(x.Name));
		foreach(var animal in animals)
			animal.SupportedMovementStates.AddRange(newMovementStates);
	}
}

//=============================================================================
