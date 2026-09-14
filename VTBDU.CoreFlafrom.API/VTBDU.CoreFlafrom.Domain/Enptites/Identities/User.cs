using System;
using System.Collections.Generic;
using System.Text;

namespace VTBDU.CoreFlafrom.Domain.Enptites.Identities; 

    internal class User
    {
    public Guid Id { get; private set; } = default!;
    public string Username { get; private set; } = default!;
    public string PasswordHash { get; private set; } = default!;
    public string? FirstName { get; private set; }
    public string? LastName { get; private set; }
}

