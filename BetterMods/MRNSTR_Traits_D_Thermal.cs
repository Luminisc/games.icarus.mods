//=============================================================================

public class MRNSTR_Traits_D_Thermal : cmk.IMB.Scripting.ModClass
{
	protected override void Execute()
	{
		var json = ExtractJson<D_Thermal>();
		
		var Thermal_Heater_Large = json.Rows.Find(x => x.Name == "Thermal_Heater_Large");		
		Thermal_Heater_Large.InnerRadius = 1250;
		
		var Thermal_Cooler_Large = json.Rows.Find(x => x.Name == "Thermal_Cooler_Large");
		Thermal_Cooler_Large.InnerRadius = 1250;
	}
}

//=============================================================================
