using ChainOfResponsibilityPattern;


AbstractLogger loggerChain = getChainOfLoggers();

loggerChain.LogMessage(AbstractLogger.INFO, "This is an information.");

loggerChain.LogMessage(AbstractLogger.DEBUG,
   "This is a debug level information.");

loggerChain.LogMessage(AbstractLogger.ERROR,
   "This is an error information.");


static AbstractLogger getChainOfLoggers()
{

    AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
    AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
    AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

    errorLogger.SetNextLogger(fileLogger);
    fileLogger.SetNextLogger(consoleLogger);

    return errorLogger;
}