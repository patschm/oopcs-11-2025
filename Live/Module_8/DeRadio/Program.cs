namespace DeRadio;

class Program
{
    static void Main(string[] args)
    {
        RadioStation r538 = new RadioStation();
        r538.Message += ViaEther;
        r538.Message += ViaKabel;
        r538.Message += ViaMail;
        r538.Message += ViaPostduif;
        r538.Message += ViaSMS;
        r538.Message += ViaEther;
        r538.Message += ViaKabel;
        r538.Message += ViaMail;
        r538.Message += ViaPostduif;
        r538.Message += ViaSMS;
        r538.Message += ViaEther;
        r538.Message += ViaKabel;
        r538.Message += ViaMail;
        r538.Message += ViaPostduif;
        r538.Message += ViaSMS;
        r538.Message += ViaPostduif;

        r538.Broardcast();
    }

    static void ViaKabel(string msg)
    {
        System.Console.WriteLine($"Via kabel: {msg}");
    }
    static void ViaSMS(string msg)
    {
        System.Console.WriteLine($"Via sms: {msg}");
    }
    static void ViaEther(string msg)
    {
        System.Console.WriteLine($"Via ether: {msg}");
    }
    static void ViaMail(string msg)
    {
        System.Console.WriteLine($"Via mail: {msg}");
    }
    static void ViaPostduif(string msg)
    {
        System.Console.WriteLine($"Via postduif: {msg}");
    }
}
