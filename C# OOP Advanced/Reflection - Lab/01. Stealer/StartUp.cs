namespace _01.Stealer
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var spy = new Spy();

            // 1. Stealer
            var result = spy.StealFieldInfo(typeof(Hacker).FullName, "username", "password");

            // 2. High Quality Mistakes
            result = spy.AnalyzeAcessModifiers(typeof(Hacker).FullName);

            // 3. Mission Private Impossible
            result = spy.RevealPrivateMethods(typeof(Hacker).FullName);

            // 4. Collector
            result = spy.CollectGettersAndSetters(typeof(Hacker).FullName);

            Console.WriteLine(result);
        }
    }
}
