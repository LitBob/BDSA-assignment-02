namespace Assignment2;

public static class Queries
{
    //LINQ
    public static IEnumerable<Wizard> GetRowlingWizardsLINQ(this WizardCollection wizColl){
        return  from w in wizColl
                where w.Creator.Contains("Rowling")
                select w;
    }
    
    //Extention Method
    public static IEnumerable<Wizard> GetRowlingWizards(this WizardCollection wizColl){
        return wizColl.Where(w => w.Creator.Contains("Rowling"));
    }

    //LINQ
    public static int? GetYearOfFirstSithLordLINQ(this WizardCollection wizColl){
        return (from w in wizColl
                where w.Name.ToLower().Contains("darth")
                orderby w.Year
                select w.Year).First();
    }

    //Extension Method
    public static int? GetYearOfFirstSithLord(this WizardCollection wizColl)
    {
        return wizColl.Where(w => w.Name.ToLower().Contains("darth")).Min(w => w.Year);        
    }

    public static IEnumerable<(string, int)> GetHarryPotterNameAndYear(this WizardCollection wizColl)
    {
        return  from w in wizColl
                where w.Medium.ToLower().Contains("harry potter")
                select (w.Name, (int)w.Year!);
    }

    public static IEnumerable<(string, int)> GetHarryPotterNameAndYearLINQ(this WizardCollection wizColl)
    {
        return wizColl.Where(w => w.Medium.ToLower().Contains("harry potter")).Select(w => (w.Name, (int)w.Year!));
    }

    public static IEnumerable<string> GetWizardNamesGroupedByCreatorLINQ(this WizardCollection wizColl)
    {
        return  from w in wizColl
                orderby w.Creator descending, w.Name
                select w.Name; 
    }

    public static IEnumerable<string> GetWizardNamesGroupedByCreator(this WizardCollection wizColl)
    {
        return wizColl.OrderByDescending(w => w.Creator).ThenBy(w => w.Name).Select(w => w.Name);
    }
}
