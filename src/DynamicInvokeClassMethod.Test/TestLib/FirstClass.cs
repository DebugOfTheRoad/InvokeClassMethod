namespace TestLib
{
    public static class FirstClass
    {
        // ReSharper disable once EmptyConstructor
        //public FirstClass()
        //{
        //}

        static FirstClass()
        {
        }

        private static string Data { get; set; }

        public static string Apply(string para)
        {
            return "first ...." + Data + "|" + para;
        }

        public static void SetValue(string data)
        {
            Data = data;
        }
    }
}