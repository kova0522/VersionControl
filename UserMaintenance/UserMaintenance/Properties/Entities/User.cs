using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class User
{
    public Guid ID { get; set; } = Guid.NewGuid();
    public string FullName { get; set; }

    public User()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
