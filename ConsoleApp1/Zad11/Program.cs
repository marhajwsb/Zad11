    
var logger1 = Logger.Instance;
logger1.Log("Pierwszy komunikat");

var logger2 = Logger.Instance;
logger2.Log("Drugi komunikat");

var logger3 = Logger.Instance;
logger2.Log("Trzeci komunikat");

var logger4 = Logger.Instance;
logger2.Log("Czwarty komunikat");

Console.WriteLine($"Czy logger1 i logger2 to ta sama instancja? {ReferenceEquals(logger1, logger2)}");

Console.WriteLine($"Czy logger3 i logger4 to ta sama instancja? {ReferenceEquals(logger3, logger4)}");

Console.WriteLine($"Czy logger1 i logger4 to ta sama instancja? {ReferenceEquals(logger1, logger4)}");

Console.WriteLine($"Czy logger2 i logger3 to ta sama instancja? {ReferenceEquals(logger2, logger3)}");


logger1.ShowLogs();
    