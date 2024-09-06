namespace itvidpradotnetcoreadvanced.Models
{
    public class GetrRoleForUser
    {
        public string GetRoleForUser(User user)
        {
            // retrieve the role from the database or another data source
            LoginContext context = new LoginContext();
            {
                var role = context.Roles
                    .Where(r => r.UserRoles.Any(u => u.UserId == user.UserId))
                    .Select(r => r.Role1)
                    .FirstOrDefault();
                return role;
            }
        }
    }
}
