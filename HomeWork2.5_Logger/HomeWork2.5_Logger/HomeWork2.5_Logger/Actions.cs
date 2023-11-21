namespace HomeWork2._5_Logger
{
    public class Actions
    {
        private Logger logger;
        public Actions(Logger logger)
        {
            this.logger = logger;
        }

        public void StartMethod()
        {
            logger.Log(LogType.Info, $"Start method: {nameof(StartMethod)}");
        }

        public void SkipLogicMethod()
        {
            try
            {
                throw new BusinessException("Skipped logic in method");
            }
            catch (BusinessException ex)
            {
                logger.Log(LogType.Warning, $"Action got this custom Exception: {ex.Message}");
            }
        }
        public void BreakLogicMethod()
        {
            try
            {
                throw new Exception("I broke a logic");
            }
            catch (Exception ex)
            {
                logger.Log(LogType.Error, $"Action failed by reason: {ex}");
            }
        }
    }
}