using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace web_application.Pages;

public class CalculatorModel : PageModel
{
    [BindProperty]
    public PropertyData Property { get; set; }

    public float CostPerSquareMeter { get; set; }

    public void OnPostCalculate()
    {
        if (Property.TotalArea > 0) // Ensure the area is greater than zero
        {
            CostPerSquareMeter = Property.PurchasePrice / Property.TotalArea;
        }
    }

    public void OnPostClear()
    {
        Property = new PropertyData(); // Reset the property data
        CostPerSquareMeter = 0; // Clear the calculated value
    }

public class PropertyData
{
    public string PropertyName { get; set; } = string.Empty; // Ensures the property is never null
    public float PurchasePrice { get; set; } = 0;
    public float Equity { get; set; } = 0;
    public string Purpose { get; set; } = string.Empty; // Ensures the property is never null
    public float ExpectedRent { get; set; } = 0;
    public int LoanTerm { get; set; } = 0;
    public float InterestRate { get; set; } = 0;
    public float TotalArea { get; set; } = 0;
}

}