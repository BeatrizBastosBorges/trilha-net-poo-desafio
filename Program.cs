using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main()
    {
        Smartphone iphone = new Iphone(numero: "123456789", modelo: "iPhone 12", imei: "111111111111111", memoria: 128);
        Smartphone nokia = new Nokia(numero: "987654321", modelo: "Nokia 3310", imei: "222222222222222", memoria: 16);

        Console.WriteLine("Testando iPhone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\nTestando Nokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Telegram");
    }
}