﻿//=============================================================================

public class MRNSTR_Traits_D_Itemable : cmk.IMB.Scripting.ModClass
{
	protected override void Execute()
	{
		var json = ExtractJson<D_Itemable>();
		
		foreach(var change in changes)
		{
			var obj = json.Rows.Find(x => x.Name == change.Key);
			obj.MaxStack = change.Value;
		}
	}
	
	Dictionary<string, int> changes = new Dictionary<string, int>()
	{
		{"Item_Fiber", 500},
		{"Item_Stone", 300},
		{"Item_Wood", 300},
		{"Item_Sulfur", 200},
		{"Item_Berry", 300},
		{"Item_Charcoal", 1000},
		{"Item_Metal_Ore", 200},
		{"Item_Refined_Metal", 100},
		{"Item_Copper_Ore", 200},
		{"Item_Refined_Copper", 100},
		{"Item_Gold_Ore", 200},
		{"Item_Refined_Gold", 100},
		{"Item_Bauxite", 200},
		{"Item_Aluminium", 100},
		{"Item_Silica", 200},
		{"Item_Glass", 100},
		{"Item_Raw_Meat", 80},
		{"Item_Cooked_Meat", 80},
		{"Item_Tree_Sap", 300},
		{"Item_Leather", 300},
		{"Item_Bone", 300},
		{"Item_Fur", 300},
		{"Item_Oxite", 200},
		{"Item_Epoxy", 200},
		{"Item_Gunpowder", 400},
		{"Item_Rifle_Round", 500},
		{"Item_MetaResource", 200},
		{"Item_Carbon_Fiber", 100},
		{"Item_Carbon_Paste", 100},
		{"Item_Composite_Paste", 100},
		{"Item_Composites", 100},
		{"Item_Bean", 300},
		{"Item_Carrot", 300},
		{"Item_Wheat", 300},
		{"Item_Shell_Buckshot", 500},
		{"Item_Shell_Explosive", 500},
		{"Item_Shell_Slug", 500},
		{"Item_Raw_Fish", 80},
		{"Item_Cooked_Fish", 80},
		{"Item_Wood_Refined", 300},
		{"Item_Ice", 200},
		{"Item_Lily", 400},
		{"Item_Reed_Flower", 400},
		{"Item_Yeast", 400},
		{"Item_Bread", 80},
		{"Item_Flatbread", 80},
		{"Item_Dough_Bread", 80},
		{"Item_Dough_Flatbread", 80},
		{"Item_Pistol_Round", 500},
		{"Item_Pistol_Round_Explosive", 500},
		{"Item_Pistol_Round_Incendiary", 500},
		{"Item_Pistol_Round_Armor_Piercing", 500},
		{"Item_Rifle_Round_Explosive", 500},
		{"Item_Rifle_Round_Incendiary", 500},
		{"Item_Rifle_Round_Armor_Piercing", 500},
		{"Item_Titanium_Ore", 200},
		{"Item_Platinum_Ore", 200},
		{"Item_Coal_Ore", 1000},
		{"Item_Titanium_Ingot", 100},
		{"Item_Platinum_Ingot", 100},
		{"Item_Raw_Prime_Meat", 80},
		{"Item_Cooked_Prime_Meat", 80},
		{"Item_Coconut", 100},
		{"Item_Coconut_Mid", 100},
		{"Item_Coconut_Mature", 100},
		{"Item_Steel_Ingot", 100},
		{"Item_Steel_Bloom", 200},
		{"Item_Glass_Jar_Jam", 80},
		{"Item_Polarbear_Pelt", 300},
		{"Item_Iron_Nail", 200},
		{"Item_Copper_Nail", 200},
		{"Item_Steel_Screw", 200},
		{"Item_Pumpkin", 300},
		{"Item_Mushroom", 300},
		{"Item_Squash", 300},
		{"Item_Watermelon", 300},
		{"Item_Cooked_Corn", 100},
		{"Item_Cooked_Pumpkin", 100},
		{"Item_Cooked_Carrot", 100},
		{"Item_Cooked_Mushroom", 100},
		{"Item_Corn_Soup", 100},
		{"Item_Fruit_Salad", 100},
		{"Item_Mushroom_Soup", 100},
		{"Item_Wild_Salad", 100},
		{"Item_Meat_Stew", 100},
		{"Item_Fried_Soy_Beans", 100},
		{"Item_Fish_Dish", 80},
		{"Item_Creamed_Corn", 100},
		{"Item_Roasted_Vegetables", 100},
		{"Item_Animal_Fat", 50},
		{"Item_Pastry", 50},
		{"Item_Fruit_Pie", 80},
		{"Item_Meat_Pie", 80},
		{"Item_Vegetable_Pie", 80},
		{"Item_Pumpkin_Bread", 80},
		{"Item_Crumbed_Fish_Fillet", 80},
		{"Item_Pickled_Carrot", 80},
		{"Item_Cocoa", 400},
		{"Item_Coffee", 400},
		{"Item_GreenTea", 400},
		{"Item_WildTea", 400},
		{"Item_Giant_Steak", 80},
		{"Item_Giant_Steak_Dried", 80},
		{"Item_Giant_Steak_Cooked", 80},
		{"Item_Fatty_Tbone", 80},
		{"Item_Fatty_Tbone_Dried", 80},
		{"Item_Fatty_Tbone_Cooked", 80},
		{"Item_Gamey_Meat", 80},
		{"Item_Gamey_Meat_Dried", 80},
		{"Item_Gamey_Meat_Cooked", 80},
		{"Item_Stringy_Meat", 80},
		{"Item_Stringy_Meat_Dried", 80},
		{"Item_Stringy_Meat_Cooked", 80},
		{"Item_Soft_Meat", 80},
		{"Item_Soft_Meat_Dried", 80},
		{"Item_Soft_Meat_Cooked", 80},
		{"Item_White_Meat", 80},
		{"Item_White_Meat_Dried", 80},
		{"Item_White_Meat_Cooked", 80},
		{"Item_Raw_Bacon", 80},
		{"Item_Cooked_Bacon", 80},
		{"Item_Crispy_Bacon", 80},
		{"Item_Clay", 300},
		{"Item_Scoria", 300},
		{"Item_Super_Cooled_Ice", 300},
		{"Item_Obsidian", 300},
		{"Item_Tomato", 300},
		{"Item_Potato", 300},
		{"Item_Clay_Brick", 400},
		{"Item_Shaped_Obsidian", 400},
		{"Item_Cooked_Potato", 100},
		{"Item_Cooked_Tomato", 300},
		{"Item_Hearty_Salad", 100},
		{"Item_Tomato_Soup", 100},
		{"Item_Pickled_Tomato", 80},
		{"Item_Potato_Carrot_Fries", 100},
		{"Item_Potato_Bread", 80},
		{"Item_Shepherds_Pie", 80},
		{"Item_Cooked_Soy_Bean", 100},
		{"Item_Fish_Chunks", 80},
		{"Item_Saltwater_Fish_Fillet", 80},
		{"Item_Freshwater_Fish_Fillet", 80},
		{"Item_Rhubarb", 300},
		{"Item_Kumara", 300},
		{"Item_Avocado", 300},
		{"Item_Strawberry", 300},
		{"Item_Dried_Tomato", 100},
		{"Item_Dried_Avocado", 100},
		{"Item_Dried_Rhubarb", 100},
		{"Item_Stuffed_Avocado", 100},
		{"Item_Rhubarb_Stew", 100},
		{"Item_Pickled_Avocado", 100},
		{"Item_Strawberry_Jam", 80},
		{"Item_Shepherds_Roll", 80},
		{"Item_Savory_Roll", 80},
		{"Item_Vegetable_Roll", 80},
		{"Item_Fruit_Muffin", 80},
		{"Item_Fish_Fillet_Pie", 80},
		{"Item_Ammo_Casing", 500},
		{"Item_Platinum_Sheath", 100},
		{"Item_Titanium_Plate", 100},
		{"Item_Obsidian_Rifle_Round", 500},
		{"Item_Obsidian_Pistol_Round", 500},
		{"Item_Cold_Steel_Rifle_Round", 500},
		{"Item_Cold_Steel_Pistol_Round", 500},
		{"Item_Iron_Wood_Rifle_Round", 500},
		{"Item_Iron_Wood_Pistol_Round", 500},
		{"Item_Scoria_Brick", 400},
		{"Item_Seed_Bread", 80},
		{"Item_Shell_Obsidian", 500},
		{"Item_Shell_Ironwood", 500},
		{"Item_Shell_ColdSteel", 500},
		{"Honeycomb", 50},
		{"Honey", 200},
		{"Beeswax", 200},
		{"Item_Giant_Steak_Smoked", 80},
		{"Item_Fatty_Tbone_Smoked", 0},
		{"Item_Gamey_Meat_Smoked", 80},
		{"Item_Stringy_Meat_Smoked", 80},
		{"Item_Soft_Meat_Smoked", 80},
		{"Item_White_Meat_Smoked", 80},
		{"Item_Smoked_Freshwater_Fillet", 80},
		{"Item_Smoked_Saltwater_Fillet", 80},
		{"Item_Dried_Meat_Generic", 80},
		{"Item_Smoked_Meat_Generic", 80},
		{"Item_Glass_Jar_Honey", 80},
		{"Item_Smokey_Bacon", 80},
		{"Item_Pastry_Honey", 80},
		{"Item_Honey_Bar", 80},
		{"Item_Animal_Feed_High_Quality", 300},
		{"Item_Cooked_Eggs", 80},
		{"Item_Mushroom_Omlette", 80},
		{"Item_Egg_Salad", 80},
		{"Item_Pickled_Eggs", 80},
		{"Item_Big_Breakfast", 80},
		{"Item_Scrambled_Eggs", 80},
		{"Item_Smashed_Avocado", 80},
		{"Item_Roast_Chicken", 80},
		{"Item_Fried_Chicken", 80},
		{"Item_Raw_Chicken", 0},
		{"Item_Grilled_Chicken", 0},
		{"Item_Dirt", 300},
		{"Item_Kiwi_Fruit", 300},
		{"Dried_Kiwifruit", 80},
		{"Kiwifruit_Jam", 80},
		{"Kiwifruit_Sorbet", 80},
		{"Fruit_Snack_Pack", 100},
		{"Item_Stone_Brick", 400},
		{"Item_Ammo_Crude", 500},
		{"Item_Coconut_Cookie", 80},
		{"Item_Caramel_Fruit_Tart", 80},
		{"Item_Salted_Caramel_Pastry", 80},
		{"Item_Chocolate_Cake", 80},
		{"Item_Chocolate_Cake_Piece", 80},
		{"Item_Carrot_Cake", 80},
		{"Item_Carrot_Cake_Piece", 80},
		{"Item_Coconut_Cake", 80},
		{"Item_Coconut_Cake_Piece", 80},
		{"Item_Cheese_Roll", 80},
		{"Item_Cheese_Pizza", 80},
		{"Item_Pavlova", 80},
		{"Item_Bacon_Sandwich", 80},
		{"Item_AssaultRifle_Round", 500},
		{"Item_AssaultRifle_Round_Explosive", 500},
		{"Item_AssaultRifle_Round_Incendiary", 500},
		{"Item_AssaultRifle_Round_Armor_Piercing", 500},
		{"Item_Obsidian_AssaultRifle_Round", 500},
		{"Item_Cold_Steel_AssaultRifle_Round", 500},
		{"Item_Iron_Wood_AssaultRifle_Round", 500},
	};
}

//=============================================================================
