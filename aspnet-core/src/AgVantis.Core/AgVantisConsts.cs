using AgVantis.Debugging;

namespace AgVantis
{
    public class AgVantisConsts
    {
        public const string LocalizationSourceName = "AgVantis";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "7475cee824e64d24a7e0b3d7cccb220e";
    }
}
