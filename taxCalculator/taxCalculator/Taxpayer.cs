using System;

public class Taxpayer
{
    private string FirstName { get; }
    private string LastName { get; }
    private string DateOfBirth { get; }
    private string TaxCode { get; set; }  // key
    private string Gender { get; }
    private string ResidenceCity { get; }
    private double AnnualIncome { get; set; }

    public Taxpayer(string firstName, string lastName, string dateOfBirth, string taxCode, string gender, string residenceCity)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        TaxCode = taxCode;
        Gender = gender;
        ResidenceCity = residenceCity;
        AnnualIncome = 0;
    }

    public void SetIncome(double income)
    {
        if (income >= 0)
            AnnualIncome = income;
        else
            Console.WriteLine("Error: Income cannot be negative!");
    }

    public double CalculateTaxes()
    {
        double tax = 0;

        if (AnnualIncome >= 0 && AnnualIncome <= 15000)
        {
            tax = AnnualIncome * 0.23;
            Console.WriteLine("You fall into the first category!");
            Console.WriteLine($"Tax to pay: ${tax}");
            Console.WriteLine("Tax rate: 23%");
        }
        else if (AnnualIncome > 15000 && AnnualIncome <= 28000)
        {
            tax = 3450 + (AnnualIncome - 15000) * 0.27;
            Console.WriteLine("You fall into the second category!");
            Console.WriteLine($"Tax to pay: ${tax}");
            Console.WriteLine("Tax rate: 27% (excess over 15k) + $3450");
        }
        else if (AnnualIncome > 28000 && AnnualIncome <= 55000)
        {
            tax = 6960 + (AnnualIncome - 28000) * 0.38;
            Console.WriteLine("You fall into the third category!");
            Console.WriteLine($"Tax to pay: ${tax}");
            Console.WriteLine("Tax rate: 38% (excess over 28k) + $6960");
        }
        else if (AnnualIncome > 55000 && AnnualIncome <= 75000)
        {
            tax = 17220 + (AnnualIncome - 55000) * 0.41;
            Console.WriteLine("You fall into the fourth category!");
            Console.WriteLine($"Tax to pay: ${tax}");
            Console.WriteLine("Tax rate: 41% (excess over 55k) + $17220");
        }
        else if (AnnualIncome > 75000)
        {
            tax = 25420 + (AnnualIncome - 75000) * 0.43;
            Console.WriteLine("You fall into the last category!");
            Console.WriteLine($"Tax to pay: ${tax}");
            Console.WriteLine("Tax rate: 43% (excess over 75k) + $25420");
        }

        return tax;
    }

    public void function()
    {
        Console.WriteLine("Tax calculator, please enter your tax code: ");
        string inputTaxCode = Console.ReadLine();

        if (inputTaxCode == TaxCode)
        {
            Console.WriteLine($"Good morning {FirstName}, please enter your income: ");
            if (!double.TryParse(Console.ReadLine(), out double income))
            {
                Console.WriteLine("Error: Please enter a valid number!");
                return;
            }

            SetIncome(income);
            Console.WriteLine("Calculating... Press ENTER to print the receipt!");
            Console.ReadLine();

            Console.WriteLine("Receipt:");
            Console.WriteLine($"Taxpayer: {FirstName} {LastName},");
            Console.WriteLine($"Born on {DateOfBirth} ({Gender}),");
            Console.WriteLine($"Resident in {ResidenceCity},");
            Console.WriteLine($"Tax code: {TaxCode}");
            Console.WriteLine($"Declared income: ${AnnualIncome}");
            CalculateTaxes();
        }
        else
        {
            Console.WriteLine("Error: Tax code not found in the database or invalid.");
        }
    }
}
