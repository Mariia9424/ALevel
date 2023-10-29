using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5;

    public class Actions
    {
        private readonly Logger logger = Logger.Instance;

        public Result StartMethod()
        {
            logger.Log("info", $"start method: {nameof(StartMethod)}");
            return new Result { Status = true };
        }

        public Result SkippedLogicInMethod()
        {
            logger.Log("warning", $"skipped logic in method: {nameof(SkippedLogicInMethod)}");
            return new Result { Status = true };
        }

        public Result MethodWithLogicError()
        {
            logger.Log("error", $"action failed by a reason: i broke a logic");
            return new Result { Status = false, Error = "i broke a logic" };
        }
    }

public class Result
{
    public bool Status { get; set; }
    public string Error { get; set; }
}

public class Starter
{
    private readonly Actions actions = new Actions();
    private readonly Logger logger = Logger.Instance;

    public void Run()
    {
        for (int i = 0; i < 100; i++)
        {
            int randomNumber = new Random().Next(1, 4);
            Result result;

            switch (randomNumber)
            {
                case 1:
                    result = actions.StartMethod();
                    break;
                case 2:
                    result = actions.SkippedLogicInMethod();
                    break;
                case 3:
                    result = actions.MethodWithLogicError();
                    break;
                default:
                    result = new Result();
                    break;
            }

            if (!result.Status)
            {
                logger.Log("error", $"action failed by a reason: {result.Error}");
            }
        }

        System.IO.File.WriteAllText("log.txt", logger.Logs);
    }
}

class Program
{
    static void Main()
    {
        Starter starter = new Starter();
        starter.Run();
    }
}