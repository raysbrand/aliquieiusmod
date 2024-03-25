public static string GetPrettyDate(DateTime d)
{
    // Calculate the time difference between the provided date and the current time
    TimeSpan ts = DateTime.Now - d;

    if (ts.Days > 365)
    {
        int years = (ts.Days / 365);
        if (ts.Days % 365 != 0)
            years += 1;
        return years == 1 ? "a year ago" : $"{years} years ago";
    }
    else if (ts.Days > 30)
    {
        int months = (ts.Days / 30);
        if (ts.Days % 30 != 0)
            months += 1;
        return months == 1 ? "a month ago" : $"{months} months ago";
    }
    else if (ts.Days > 0)
    {
        return ts.Days == 1 ? "a day ago" : $"{ts.Days} days ago";
    }
    else if (ts.Hours > 0)
    {
        return ts.Hours == 1 ? "an hour ago" : $"{ts.Hours} hours ago";
    }
    else if (ts.Minutes > 0)
    {
        return ts.Minutes == 1 ? "a minute ago" : $"{ts.Minutes} minutes ago";
    }
    else
    {
        return "just now";
    }
}
