public abstract class Validators
{
    public static bool ValidateName(string name)
    {
        return name.Length > 3 ? true : false;  
    }

    public static bool ValidateAge(int age)
    {
        return age >= 0 && age <= 150 ? true : false;
    }

    public static bool ValidateWage(double wage)
    {
        return wage > 0 ? true : false;
    }

    public static bool ValidateGender(char gender)
    {
        gender = char.ToUpper(gender);

        return gender.Equals('M') || gender.Equals('F') ? true : false;
    }

    public static bool ValidateStatus(char status)
    {
        status = char.ToUpper(status);

        return status.Equals('S') || status.Equals('C') 
        || status.Equals('V') || status.Equals('D')  ? true : false;
    }
}