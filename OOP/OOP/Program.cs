// See https://aka.ms/new-console-template for more information
/* Object Oriented Programs */
using OOP;
bool check = true;
while (check)
{
    Console.Write("Select Option:\n1)Stock Management\n2)Json Inventory Management\n");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            StockManagment uc = new StockManagment();
            uc.AddStock();
            break;
        case 2:
            JSON_Inventory invent = new JSON_Inventory();
            string filePath = @"D:\Bridgelab\OOP\OOP\OOP\JSONFile\inventorymanagement.json";
            invent.ReadJson(filePath);
            break;
        default:
            check = !check;
            break;
    }
}