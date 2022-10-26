using System.Text.Json;
using System.Text.Json.Serialization;

namespace cafe_managment_2.Model { }
public class Items
{
    [JsonPropertyName("id")]
    public int items_id { get; set; }
    [JsonPropertyName("name")]
    public string items_name { get; set; }
    [JsonPropertyName("price")]
    public int items_price { get; set; }
    public override string ToString()
    //To store data in files
    {
        return JsonSerializer.Serialize(this);
    }