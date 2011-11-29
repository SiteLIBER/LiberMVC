
using System.Linq;
public class FbJsonItem
{
	public int ID { get; set; }
	public string Name { get; set; }
}

public class FbJson
{
	public static string Create(IQueryable<FbJsonItem> itens)
	{
		var FbJson = "{";
		itens.ToList().ForEach(f => FbJson += "'" + f.ID + "':'" + f.Name + "',");
		FbJson += "}";
		return FbJson;
	}
}