// See https://aka.ms/new-console-template for more information
Console.WriteLine(sizeof(sbyte));
Console.WriteLine("min value sbyte = "+ sbyte.MinValue);
Console.WriteLine("max value sbyte=" + sbyte.MaxValue);

Console.WriteLine(sizeof(byte));
Console.WriteLine("min value byte=" +byte.MinValue);
Console.WriteLine("max value byte-" + byte.MaxValue);

Console.WriteLine(sizeof(short));
Console.WriteLine("min value short=" + short.MinValue);
Console.WriteLine("max value short=" + short.MaxValue);

Console.WriteLine(sizeof(ushort));
Console.WriteLine("min value ushort="+ ushort.MinValue);
Console.WriteLine("max value ushort=" +ushort.MaxValue);

Console.WriteLine(sizeof(int));
Console.WriteLine("min value int=" + int.MinValue);
Console.WriteLine("max value int=" + int.MaxValue);

Console.WriteLine(sizeof(uint));
Console.WriteLine("min value uint=" + uint.MinValue);
Console.WriteLine("max value uint=" +uint.MaxValue);

Console.WriteLine(sizeof(long));
Console.WriteLine("min value long=" + long.MinValue);
Console.WriteLine("max value long=" +long.MaxValue);

Console.WriteLine(sizeof(ulong));
Console.WriteLine("min value ulong=" + ulong.MinValue);
Console.WriteLine("max value ulong=" +ulong.MaxValue);

Console.WriteLine(sizeof(float));
Console.WriteLine("min value float=" + float.MinValue);
Console.WriteLine("max value float=" +float.MaxValue);

Console.WriteLine(sizeof(double));
Console.WriteLine("min value double=" + double.MinValue);
Console.WriteLine("max value double=" +double.MaxValue);

Console.WriteLine(sizeof(decimal));
Console.WriteLine("min value decimal=" + decimal.MinValue);
Console.WriteLine("max value decimal=" +decimal.MaxValue);

for(int i=0; i<=100; i++){
    if(i%3==0 && i%5==0){
        Console.WriteLine("FizzBuzz");
    }else if(i%3==0){
        Console.WriteLine("Fizz");
    } if(i%5==0){
        Console.WriteLine("Buzz");
    }else{
        Console.WriteLine(i);
    }
}




