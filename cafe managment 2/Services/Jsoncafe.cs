using Microsoft.AspNetCore.Hosting
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace cafe_managment_2.Services
public class Jsoncafe
{
     {   public Jsoncafe.Jsoncafe(IWebHostEnvironment webHostEnvironment);

    IWebHostEnvironment= webHostEnvironment


}
public IWebHostEnvironment.WebHostEnvironment(get;)

public string JsonFilePath
    public IEnumerable<Items>.getItemsdata
    { using(var Json_file=File.Opentext(JsonFilepath))
   JsonSerializer.Deserialize<Items[]>(Json_file.ReadtoEnd())
}

{
    get;
return Path.Combine(WebHostEnvironment.webRootpath, "data,"Items.json ");

}
}