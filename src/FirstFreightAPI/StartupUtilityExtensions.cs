namespace FirstFreightAPI
{
    public static class StartupUtilityExtensions
    {
        public static string ValidateNotNull(this string? value, string keyName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value), keyName);
            }

            return value;
        }
    }
}
