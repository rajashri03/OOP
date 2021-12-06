using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OOP
{
    
    public class JSON_Inventory
    {
        List<InventoryModel> newInventory = new List<InventoryModel>();
        public void ReadJson(string filePath)
        {

            using (StreamReader reader = new StreamReader(filePath))
            {
                var jsonobject = reader.ReadToEnd();
               newInventory = JsonConvert.DeserializeObject<List<InventoryModel>>(jsonobject);
                foreach(InventoryModel model in newInventory)
                {
                    Console.WriteLine("Name:" + model.Name);
                    Console.WriteLine("Weight:" + model.Weight);
                    Console.WriteLine("Price:" + model.Price);
                    Console.WriteLine("*********************\n");
                }
                
            }
        }

    }
}
