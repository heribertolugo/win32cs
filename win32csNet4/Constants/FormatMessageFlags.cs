namespace Win32.Constants
{
    public static class FormatMessageFlags
    {
        public const uint FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x00000100;
        public const uint FORMAT_MESSAGE_IGNORE_INSERTS = 0x00000200;
        public const uint FORMAT_MESSAGE_FROM_STRING = 0x00000400;
        public const uint FORMAT_MESSAGE_FROM_HMODULE = 0x00000800;
        public const uint FORMAT_MESSAGE_FROM_SYSTEM = 0x00001000;
        public const uint FORMAT_MESSAGE_ARGUMENT_ARRAY = 0x00002000;
        public const uint FORMAT_MESSAGE_MAX_WIDTH_MASK = 0x000000FF;
    }
}
