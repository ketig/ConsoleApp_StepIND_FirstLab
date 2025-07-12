bool valid = IsValidEmail("user@gmail.com");

static bool IsValidEmail(string email)
{
    if (string.IsNullOrEmpty(email))
    {
        return false;
    }

    int index = email.IndexOf("@");
    if (index < 0 /*!email.Contains('@')*/)
    {
        return false;
    }

    // @ -მდე უნდა იყოს მინიმუმ 1 სიმბოლო
    if (index == 0)
    {
        return false;
    }

    // @ -ის შემდეგ უნდა იყოს მინიმუმ 1 სიმბოლო
    // უნდა შეიცავდეს წერტილს @ -ის შემდეგ

    return true;
}