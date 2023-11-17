namespace HomeWork2._5_Logger
{
    public class App
    {
        public static void Run()
        {
            Logger logger = new Logger();
            Actions actions = new Actions(logger);

            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                int actionNumber = random.Next(1, 4);

                try
                {
                    switch (actionNumber)
                    {
                        case 1:
                            actions.StartMethod();
                            break;
                        case 2:
                            actions.SkipLogicMethod();
                            break;
                        case 3:
                            actions.BreakLogicMethod();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    logger.Log(LogType.Error, $"Action failed by reason: {ex}");
                }
            }

            FileService.CleanUpOldFiles("Logs");
            logger.WriteToJSONFile("Logs/logEntries.json");
        }
    }
}