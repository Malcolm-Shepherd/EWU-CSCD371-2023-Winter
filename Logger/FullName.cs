namespace Logger;
public record class FullName(string FirstName, string LastName, string? MiddleName = null)
{
/*Reference type as different people can have the same full name.
  Read only as it is very rare for people to need to change their name.
  Null checks on First and Last as they are needed.
  Middle name is optional, so no checks are needed.
 */
    public string FirstName { get; } = FirstName??throw new ArgumentNullException(nameof(FirstName));
    public string LastName { get; } = LastName??throw new ArgumentNullException(nameof(LastName));
    public string? MiddleName { get; } = MiddleName;
}
