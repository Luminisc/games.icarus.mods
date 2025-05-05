//=============================================================================

public class MRNSTR_D_ProcessorRecipes : cmk.IMB.Scripting.ModClass
{
	protected override void Execute()
	{
		var json = ExtractJson<D_ProcessorRecipes>();
		var seedExtractorRecipes = json.Rows
						.Where(x => x.RecipeSets != null 
					       && x.RecipeSets.Any(y => y.RowName == "Seed_Extractor"));
		foreach( var recipe in seedExtractorRecipes ) {
			recipe.RequiredMillijoules /= 5;
		}
	}
}

//=============================================================================
