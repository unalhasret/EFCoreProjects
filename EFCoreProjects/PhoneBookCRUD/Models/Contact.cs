using System;
using System.Collections.Generic;

namespace PhoneBookCRUD.Models;

public partial class Contact
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string? PhoneNumber { get; set; }
}
