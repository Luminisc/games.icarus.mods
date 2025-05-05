//=============================================================================

public class MRNSTR_Traits_D_Generator : cmk.IMB.Scripting.ModClass
{
	protected override void Execute()
	{
		var json = ExtractJson<D_Generator>();
		
		var Kit_Generator_Energy_Generator = json.Rows.Find(x => x.Name == "Kit_Generator_Energy_Generator");		
		Kit_Generator_Energy_Generator.GenerationRate = 6000;
		
		var Deep_Mining_Biofuel_Drill = json.Rows.Find(x => x.Name == "Deep_Mining_Biofuel_Drill");
		Deep_Mining_Biofuel_Drill.GenerationRatio = 1.5;
	}
}

//=============================================================================
