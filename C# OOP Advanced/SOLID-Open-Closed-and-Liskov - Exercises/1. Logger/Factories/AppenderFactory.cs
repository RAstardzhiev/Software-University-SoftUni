namespace _1.Logger.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Interfaces;

    public class AppenderFactory
    {
        public IAppender CreateAppender(string appenderName, string layoutName)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            var layoutType = types.FirstOrDefault(t => t.Name == layoutName);
            var appenderType = types.FirstOrDefault(t => t.Name == appenderName);

            var layout = (ILayout)Activator.CreateInstance(layoutType);
            var appender = (IAppender)Activator.CreateInstance(appenderType, new object[] { layout });

            return appender;
        }
    }
}
