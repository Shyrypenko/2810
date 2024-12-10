using System;

public class ForeignPassport
{
    private string passportNumber;
    private string fullName;
    private DateTime issueDate;

    public string PassportNumber
    {
        get => passportNumber;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length != 9 || !long.TryParse(value, out _))
                throw new ArgumentException("Invalid passport number format. It must consist of 9 digits.");
            passportNumber = value;
        }
    }

    public string FullName
    {
        get => fullName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Full name cannot be empty.");
            fullName = value;
        }
    }

    public DateTime IssueDate
    {
        get => issueDate;
        set
        {
            if (value > DateTime.Now)
                throw new ArgumentException("Issue date cannot be in the future.");
            issueDate = value;
        }
    }

    public ForeignPassport(string passportNumber, string fullName, DateTime issueDate)
    {
        PassportNumber = passportNumber;
        FullName = fullName;
        IssueDate = issueDate;
    }

    public override string ToString()
    {
        return $"Passport Number: {PassportNumber}\nFull Name: {FullName}\nIssue Date: {IssueDate:yyyy-MM-dd}";
    }
}
