// See https://aka.ms/new-console-template for more information

using TP1;

chauffeur navigo = new chauffeur("pannini", "bobby", 1233963, true, "aucune");

navigo.AfficherInfos();

try
{
    navigo.Assignermission("paname");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}



